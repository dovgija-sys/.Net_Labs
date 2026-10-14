using program_lab5.Interfaces;
using System.Text.Json;

namespace program_lab5.Logic
{
    public class JsonFileReader : IFileLoader
    {
        public async Task<List<T>?> LoadAsync<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }
    }
}
