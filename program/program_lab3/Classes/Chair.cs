using program_lab3.Interfaces;

namespace program_lab3.Classes
{
    public class Chair : Furniture, IInstructable
    {
        public Chair() : base()
        {

        }
        public Chair(string type, string material, double price, bool hashaigthadjustment) : base(type, material, price)
        {
            HasHaigthAdjustment = hashaigthadjustment;
        }
        public bool HasHaigthAdjustment { get; set; }
        public string GetAssemblyInstructions()
        {
            return HasHaigthAdjustment ? "Збірка стільця: прикрутіть ніжки до сидіння та встановіть механізм регулювання висоти." : "Збірка стільця: прикрутіть ніжки до сидіння.";
        }
        public override string Assembly()
        {
            string adjustment;
            if (HasHaigthAdjustment)
            {
                adjustment = "з регулюванням висоти";
            }
            else
            {
                adjustment = "без регулювання висоти";
            }
            return $"Збірка стільця: встановіть спинку та перевірте механізм ({adjustment}).";
        }
        public override string Clean()
        {
            return $"Очищення стільця: використовуйте засіб для матеріалу '{Material}'.";
        }
    }
}
