namespace program_lab3.Classes
{
    public class FurnitureAnalysis
    {
        public double GetTotalPriceByMaterial(List<Furniture> furnitures, string material)
        {
            double sum = 0.0;
            foreach(var furniture in furnitures)
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
