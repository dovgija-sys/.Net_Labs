namespace program_lab3.Classes
{
    public class Table : Furniture
    {
        public Table()  : base()
        {
            Shape = "Unknown";
        }
        public Table(string type, string material, double price, string shape) : base(type, material, price)
        {
            Shape = shape;
        }
        public string Shape { get; set; }
        public string GetDimensions()
        {
            var random = new Random();
            var width = random.Next(60, 121);
            var length = random.Next(80, 251);
            return $"Розміри для столу форми '{Shape}' - {length}x{width} см.";
        }
        public override string Assembly()
        {
            return$"Збірка столу: прикрутіть ніжки до стільниці. Форма: {Shape}.";
        }
        public override string Clean()
        {
            return $"Чистка столу: протріть стільницю та ніжки." +
                $"\nВикористовуйте засіб для матеріалу '{Material}'." +
                $"Форма: {Shape}.";
        }
    }
}
