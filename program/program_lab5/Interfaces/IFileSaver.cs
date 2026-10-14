namespace program_lab5.Interfaces
{
    public interface IFileSaver
    {
        Task SaveAsync<T>(string filePath, List<T> data);
    }
}
