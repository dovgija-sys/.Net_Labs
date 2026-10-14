using program_lab5.Logic;
namespace UnitTests.lab_5
{
    [TestClass]
    public class JsonTests
    {
        [TestMethod]
        public async Task JsonFileSaverAndReader_ShouldWriteAndReadCorrectly()
        {
            var saver = new JsonFileSaver();
            var reader = new JsonFileReader();

            var list = new List<CloakRoom>
            {
                new CloakRoom("Іванов І.І.", 1, 2.5),
                new CloakRoom("Петров П.П.", 2, 3.0)
            };

            string tempFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".json");
            try
            {
                await saver.SaveAsync(tempFile, list);

                var loaded = await reader.LoadAsync<CloakRoom>(tempFile);

                Assert.IsNotNull(loaded);
                Assert.AreEqual(list.Count, loaded!.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    Assert.AreEqual(list[i].FullName, loaded[i].FullName);
                    Assert.AreEqual(list[i].Count, loaded[i].Count);
                    Assert.AreEqual(list[i].TotalWeight, loaded[i].TotalWeight);
                }
            }
            finally
            {
                if (File.Exists(tempFile)) File.Delete(tempFile);
            }
        }

        [TestMethod]
        public async Task JsonFileReader_LoadAsync_ShouldReturnNull_WhenFileDoesNotExist()
        {
            var reader = new JsonFileReader();
            string tempFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".json");
            if (File.Exists(tempFile)) File.Delete(tempFile);

            var result = await reader.LoadAsync<CloakRoom>(tempFile);

            Assert.IsNull(result);
        }
    }
}
