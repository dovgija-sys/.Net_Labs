using program_lab5.Logic;
using program_lab5.Interfaces;
using System.Collections.ObjectModel;
namespace program_lab5
{
    public partial class Form1 : Form
    {
        private CloakRoomCatalog _catalog;

        public Form1()
        {
            InitializeComponent();

            string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "cloakrooms.json");
            IFileSaver saver = new JsonFileSaver();
            IFileLoader loader = new JsonFileReader();
            _catalog = new CloakRoomCatalog(saver, loader, defaultPath);

            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                await _catalog.LoadAsync();
                RefreshList(_catalog.CloakRooms);
                lblStatus.Text = "Loaded";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Load failed: " + ex.Message;
            }
        }



        private void RefreshList(ObservableCollection<CloakRoom> source)
        {
            listViewCloakRooms.BeginUpdate();
            listViewCloakRooms.Items.Clear();
            foreach (var item in source)
            {
                var lvi = new ListViewItem(new[] { item.FullName, item.Count.ToString(), item.TotalWeight.ToString() });
                lvi.Tag = item;
                listViewCloakRooms.Items.Add(lvi);
            }
            listViewCloakRooms.EndUpdate();
        }

        private void RefreshList(List<CloakRoom> list)
        {
            listViewCloakRooms.BeginUpdate();
            listViewCloakRooms.Items.Clear();
            foreach (var item in list)
            {
                var lvi = new ListViewItem(new[] { item.FullName, item.Count.ToString(), item.TotalWeight.ToString() });
                lvi.Tag = item;
                listViewCloakRooms.Items.Add(lvi);
            }
            listViewCloakRooms.EndUpdate();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text?.Trim() ?? string.Empty;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Enter full name");
                    return;
                }

                int count = (int)nudCount.Value;
                double weight = (double)nudTotalWeight.Value;

                var room = new CloakRoom(name, count, weight);
                _catalog.AddCloakRoom(room);
                RefreshList(_catalog.CloakRooms);
                lblStatus.Text = "Added";
                txtFullName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (listViewCloakRooms.SelectedItems.Count == 0) return;
            var selected = listViewCloakRooms.SelectedItems[0];
            var toRemove = selected.Tag as CloakRoom;
            if (toRemove != null)
            {
                _catalog.DeleteCloakRoom(toRemove);
                RefreshList(_catalog.CloakRooms);
                lblStatus.Text = "Deleted";
            }
        }


        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            lblStatus.Text = "Saving...";
            try
            {
                await _catalog.SaveAsync();
                lblStatus.Text = "Saved";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Save error: " + ex.Message;
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private async void BtnLoad_Click(object? sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            lblStatus.Text = "Loading...";
            try
            {
                await _catalog.LoadAsync();
                RefreshList(_catalog.CloakRooms);
                lblStatus.Text = "Loaded";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Load error: " + ex.Message;
            }
            finally
            {
                btnLoad.Enabled = true;
            }
        }

        private void BtnFilter_Click(object? sender, EventArgs e)
        {
            double threshold = (double)nudWeightThreshold.Value;
            var filtered = _catalog.GetPassengersWithWeightExceeding(threshold);
            RefreshList(filtered);
            lblStatus.Text = $"Filtered: {filtered.Count} items";
        }

        private void BtnSort_Click(object? sender, EventArgs e)
        {
            _catalog.SortByFullName();
            RefreshList(_catalog.CloakRooms);
            lblStatus.Text = "Sorted";
        }

        private void LstCloakRooms_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnDelete.Enabled = listViewCloakRooms.SelectedItems.Count > 0;
        }
    }
}
