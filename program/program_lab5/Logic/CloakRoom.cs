namespace program_lab5.Logic
{
    public class CloakRoom : IComparable<CloakRoom>
    {
        private string? _fullName;
        private int _count;
        private double _totalWeight;

        public CloakRoom()
        {
       
        }
        public CloakRoom(string fullName, int count, double totalWeight)
        {
            FullName = fullName;
            Count = count;
            TotalWeight = totalWeight;
        }
        public string FullName
        {
            get => _fullName;
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(value);
                _fullName = value;
            }
        }
        public int Count
        {
            get => _count;
            set 
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
                _count = value; 
            }
        }
        public double TotalWeight
        {
            get => _totalWeight;
            set 
            { 
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
                _totalWeight = value;
            }
        }
        public int CompareTo(CloakRoom cloakRoom)
        {
            if(cloakRoom == null)
            {
                return 1;
            }
            return string.Compare(FullName, cloakRoom.FullName, StringComparison.Ordinal);
        }
        public override string ToString()
        {
            return $"ПІБ: {FullName}, Кількість речей: {Count}, Загальна вага речей: {TotalWeight}";
        }
    }
}
