
namespace program_lab5.Interfaces
{
    public interface IFileLoader
    {
        Task<List<T>?> LoadAsync<T>(string filePath);
    }
}
