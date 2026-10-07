using program_lab3.Classes;
using System.Collections.ObjectModel;

namespace program_lab3.Interfaces
{
    public interface IFurnitureAnalysis
    {
        double GetTotalPriceByMaterial(ObservableCollection<IFurniture> furnitures, string material);
    }
}