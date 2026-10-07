namespace program_lab3.Interfaces
{
    public interface IFurniture
    {
        string Material { get; set; }
        double Price { get; set; }
        string Type { get; set; }

        string Assembly();
        string Clean();
    }
}