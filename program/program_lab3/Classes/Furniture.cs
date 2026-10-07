using program_lab3.Interfaces;

namespace program_lab3.Classes
{
    public abstract class Furniture : IFurniture
    {
        private double _price;
        public Furniture()
        {
            Type = "Unknown";
            Material = "Unknown";
            Price = 0.0;
        }
        public Furniture(string type, string material, double price)
        {
            Type = type;
            Material = material;
            Price = price;
        }
        public string Type { get; set; }
        public string Material { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0) { throw new("Price can't be less than 0"); }
                _price = value;
            }
        }
        public abstract string Assembly();
        public abstract string Clean();
    }
}
