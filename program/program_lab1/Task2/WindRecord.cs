namespace program_lab1.Task2
{
    public class WindRecord
    {
        public string Direction { get; set; }
        public int Power { get; set; }
        public WindRecord(string direction, int power)
        {
            Direction = direction;
            Power = power;
        }
    }
}
