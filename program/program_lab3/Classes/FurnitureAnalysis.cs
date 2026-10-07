using program_lab3.Interfaces;
using System.Collections.ObjectModel;

namespace program_lab3.Classes
{
    public class FurnitureAnalysis : IFurnitureAnalysis
    {
        public double GetTotalPriceByMaterial(ObservableCollection<IFurniture> furnitures, string material)
        {
            double sum = 0.0;
            foreach (var furniture in furnitures)
            {
                if (furniture.Material == material)
                {
                    sum += furniture.Price;
                }
            }
            return sum;
        }
    }
}
