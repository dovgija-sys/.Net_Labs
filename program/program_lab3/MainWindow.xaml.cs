using System.Windows;
using System.Windows.Controls;
using program_lab3.Classes;

namespace program_lab3
{
    public partial class MainWindow : Window
    {
        private List<Furniture> _furnitureList = [];

        public MainWindow()
        {
            InitializeComponent();
            FurnitureTypeComboBox.SelectedIndex = 0;
            SetInitialUiState();
        }

        private void FurnitureTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetInitialUiState();
        }

        private void SetInitialUiState()
        {
            if (TableFields == null) return;

            if (FurnitureTypeComboBox.SelectedIndex == 0)
            {
                TableFields.Visibility = Visibility.Visible;
                TableInputs.Visibility = Visibility.Visible;
                ChairFields.Visibility = Visibility.Collapsed;
                ChairInputs.Visibility = Visibility.Collapsed;

                GetDimensionsButton.Visibility = Visibility.Visible;
                GetInstructionButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                TableFields.Visibility = Visibility.Collapsed;
                TableInputs.Visibility = Visibility.Collapsed;
                ChairFields.Visibility = Visibility.Visible;
                ChairInputs.Visibility = Visibility.Visible;

                GetDimensionsButton.Visibility = Visibility.Collapsed;
                GetInstructionButton.Visibility = Visibility.Visible;
            }
        }

        private Furniture CreateFurnitureFromInputs()
        {
            string type = TypeTextBox.Text;
            string material = MaterialTextBox.Text;
            double price = double.Parse(PriceTextBox.Text);

            if (FurnitureTypeComboBox.SelectedIndex == 0)
            {
                string shape = ShapeTextBox.Text;
                return new Table(type, material, price, shape);
            }
            else
            {
                bool hasAdjustment = HeightAdjustmentCheckBox.IsChecked ?? false;
                return new Chair(type, material, price, hasAdjustment);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var furniture = CreateFurnitureFromInputs();
                _furnitureList.Add(furniture);
                FurnitureListBox.Items.Add($"[Added] {furniture.Type} | Material: {furniture.Material} | Price: ${furniture.Price}");
                UpdateAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AssembleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var furniture = CreateFurnitureFromInputs();
                _furnitureList.Add(furniture);
                FurnitureListBox.Items.Add($"[Assembly] {furniture.Assembly()} | Price: ${furniture.Price}");
                UpdateAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CleanButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var furniture = CreateFurnitureFromInputs();
                _furnitureList.Add(furniture);
                FurnitureListBox.Items.Add($"[Cleaning] {furniture.Clean()}");
                UpdateAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GetDimensionsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var table = (Table)CreateFurnitureFromInputs();
                _furnitureList.Add(table);
                FurnitureListBox.Items.Add($"[Dimensions] {table.GetDimensions()}");
                UpdateAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GetInstructionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var chair = (Chair)CreateFurnitureFromInputs();
                _furnitureList.Add(chair);
                FurnitureListBox.Items.Add($"[Instruction] {chair.GetAssemblyInstructions()}");
                UpdateAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SearchMaterialTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAnalytics();
        }

        private void UpdateAnalytics()
        {
            string targetMaterial = SearchMaterialTextBox.Text.Trim();
            if (string.IsNullOrEmpty(targetMaterial))
            {
                TotalMaterialPriceTextBlock.Text = "$0.00";
                return;
            }
            var analysis = new FurnitureAnalysis();
            double total = analysis.GetTotalPriceByMaterial(_furnitureList, targetMaterial);
            TotalMaterialPriceTextBlock.Text = $"${total:F2}";
        }
    }
}