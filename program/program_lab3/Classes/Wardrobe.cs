using program_lab3.Interfaces;

namespace program_lab3.Classes
{
    public class Wardrobe : Furniture, IInstructable
    {
        private int _doorsCount;

        public Wardrobe() : base()
        {
            DoorsCount = 2;
        }
        public Wardrobe(string type, string material, double price, int doorsCount) : base(type, material, price)
        {
            DoorsCount = doorsCount;
        }
        public int DoorsCount
        {
            get { return _doorsCount; }
            set
            {
                if (value < 1) { throw new("Doors count can't be less than 1"); }
                _doorsCount = value;
            }
        }
        public string GetAssemblyInstructions()
        {
            return $"Збірка шафи: зберіть каркас, встановіть полиці та навісьте двері ({DoorsCount} шт.).";
        }
        public override string Assembly()
        {
            return $"Збірка шафи: скріпіть каркас і задню стінку, встановіть дверей: {DoorsCount}.";
        }
        public override string Clean()
        {
            return $"Очищення шафи: протріть фасади та полиці засобом для матеріалу '{Material}'.";
        }
    }
}
