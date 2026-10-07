using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using program_lab3.Classes;
using program_lab3.Interfaces;

namespace program_lab3
{
    public partial class MainWindow : Window
    {
        // Колекція зберігає посилання на інтерфейс (поліморфізм).
        // ObservableCollection одразу відображається у FurnitureObjectsListBox.
        private readonly ObservableCollection<IFurniture> _furnitureList = [];
        private readonly IFurnitureAnalysis _analysis = new FurnitureAnalysis();

        private const int TableIndex = 0;
        private const int ChairIndex = 1;
        private const int WardrobeIndex = 2;

        public MainWindow()
        {
            InitializeComponent();
            FurnitureObjectsListBox.ItemsSource = _furnitureList;
            FurnitureTypeComboBox.SelectedIndex = TableIndex;
            SetInitialUiState();
        }

        private void FurnitureTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetInitialUiState();
        }

        private void SetInitialUiState()
        {
            if (TableFields == null) return;

            int index = FurnitureTypeComboBox.SelectedIndex;

            TableFields.Visibility = index == TableIndex ? Visibility.Visible : Visibility.Collapsed;
            TableInputs.Visibility = TableFields.Visibility;

            ChairFields.Visibility = index == ChairIndex ? Visibility.Visible : Visibility.Collapsed;
            ChairInputs.Visibility = ChairFields.Visibility;

            WardrobeFields.Visibility = index == WardrobeIndex ? Visibility.Visible : Visibility.Collapsed;
            WardrobeInputs.Visibility = WardrobeFields.Visibility;
        }

        // Створює об'єкт із полів вводу. Викликається ТІЛЬКИ з кнопки Add.
        private IFurniture CreateFurnitureFromInputs()
        {
            string type = TypeTextBox.Text;
            string material = MaterialTextBox.Text;
            double price = double.Parse(PriceTextBox.Text);

            switch (FurnitureTypeComboBox.SelectedIndex)
            {
                case TableIndex:
                    return new Table(type, material, price, ShapeTextBox.Text);
                case ChairIndex:
                    bool hasAdjustment = HeightAdjustmentCheckBox.IsChecked ?? false;
                    return new Chair(type, material, price, hasAdjustment);
                default:
                    int doors = int.Parse(DoorsTextBox.Text);
                    return new Wardrobe(type, material, price, doors);
            }
        }

        // Повертає вибраний у списку об'єкт (або показує підказку)
        private IFurniture? GetSelectedFurniture()
        {
            if (FurnitureObjectsListBox.SelectedItem is IFurniture furniture)
            {
                return furniture;
            }
            MessageBox.Show("Select a furniture item in the list first.", "Info");
            return null;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var furniture = CreateFurnitureFromInputs();
                _furnitureList.Add(furniture);
                FurnitureObjectsListBox.SelectedItem = furniture;
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
            var furniture = GetSelectedFurniture();
            if (furniture == null) return;
            FurnitureListBox.Items.Add($"[Assembly] {furniture.Assembly()} | Price: ${furniture.Price}");
        }

        private void CleanButton_Click(object sender, RoutedEventArgs e)
        {
            var furniture = GetSelectedFurniture();
            if (furniture == null) return;
            FurnitureListBox.Items.Add($"[Cleaning] {furniture.Clean()}");
        }

        private void GetDimensionsButton_Click(object sender, RoutedEventArgs e)
        {
            var furniture = GetSelectedFurniture();
            if (furniture == null) return;

            if (furniture is Table table)
            {
                FurnitureListBox.Items.Add($"[Dimensions] {table.GetDimensions()}");
            }
            else
            {
                MessageBox.Show("Dimensions are available only for a table.", "Info");
            }
        }

        private void GetInstructionButton_Click(object sender, RoutedEventArgs e)
        {
            var furniture = GetSelectedFurniture();
            if (furniture == null) return;

            if (furniture is IInstructable instructable)
            {
                FurnitureListBox.Items.Add($"[Instruction] {instructable.GetAssemblyInstructions()}");
            }
            else
            {
                MessageBox.Show("This item has no assembly instructions (chair or wardrobe only).", "Info");
            }
        }

        // Демонстрація поліморфізму: одна колекція IFurniture, різна поведінка
        private void AssembleAllButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (IFurniture furniture in _furnitureList)
            {
                FurnitureListBox.Items.Add($"[Assemble All] {furniture.Type}: {furniture.Assembly()}");
            }
        }

        // Демонстрація поліморфізму: вибірка за інтерфейсом IInstructable
        private void AllInstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (IInstructable instructable in _furnitureList.OfType<IInstructable>())
            {
                FurnitureListBox.Items.Add($"[All Instructions] {instructable.GetAssemblyInstructions()}");
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
            double total = _analysis.GetTotalPriceByMaterial(_furnitureList, targetMaterial);
            TotalMaterialPriceTextBlock.Text = $"${total:F2}";
        }
    }
}
