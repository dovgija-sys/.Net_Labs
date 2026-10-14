using program_lab5.Interfaces;
using System.Collections.ObjectModel;

namespace program_lab5.Logic
{
    public class CloakRoomCatalog
    {
        private readonly IFileSaver _fileSaver;
        private readonly IFileLoader _fileLoader;
        private readonly string _filePath;

        public ObservableCollection<CloakRoom> CloakRooms { get; }

        private List<CloakRoom> _allCloakRooms;

        public CloakRoomCatalog(IFileSaver fileSaver, IFileLoader fileLoader, string filePath)
        {
            _fileSaver = fileSaver;
            _fileLoader = fileLoader;
            _filePath = filePath;

            CloakRooms = new ObservableCollection<CloakRoom>();
            _allCloakRooms = new List<CloakRoom>();
        }

        public void AddCloakRoom(CloakRoom cloakRoom)
        {
            CloakRooms.Add(cloakRoom);
            _allCloakRooms.Add(cloakRoom);
        }

        public void DeleteCloakRoom(CloakRoom cloakRoom)
        {
            CloakRooms.Remove(cloakRoom);
            _allCloakRooms.Remove(cloakRoom);
        }

        public void SortByFullName()
        {
            var sorted = new List<CloakRoom>(CloakRooms);
            sorted.Sort(new CloakRoomFullNameComparer());
            UpdateVisibleCollection(sorted);
        }

        public List<CloakRoom> GetPassengersWithWeightExceeding(double threshold)
        {
            var filtered = new List<CloakRoom>();

            foreach (var c in _allCloakRooms)
            {
                if (c.TotalWeight > threshold)
                {
                    filtered.Add(c);
                }
            }

            filtered.Sort((a, b) => b.Count.CompareTo(a.Count));

            return filtered;
        }

        private void UpdateVisibleCollection(List<CloakRoom> list)
        {
            CloakRooms.Clear();
            foreach (var item in list)
            {
                CloakRooms.Add(item);
            }
        }

        public async Task SaveAsync()
        {
            await _fileSaver.SaveAsync(_filePath, _allCloakRooms);
        }

        public async Task LoadAsync()
        {
            var loaded = await _fileLoader.LoadAsync<CloakRoom>(_filePath);
            if (loaded != null)
            {
                _allCloakRooms = loaded;
                UpdateVisibleCollection(_allCloakRooms);
            }
        }
    }
}
