
using program_lab5.Interfaces;
using System.Text.Json;

namespace program_lab5.Logic
{
    public class JsonFileSaver : IFileSaver
    {
        public async Task SaveAsync<T>(string filePath, List<T> data)
        {
            string? directoryPath = Path.GetDirectoryName(filePath);
            if(directoryPath!=null && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true});
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}
