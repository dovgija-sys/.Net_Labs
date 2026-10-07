using program_lab3.Classes;

namespace UnitTests.lab_3
{
    [TestClass]
    public class UnitTest_lab3
    {
        [TestMethod]
        public void TestNegativePrice()
        {
            Assert.Throws<Exception>(() => new Chair("Office Chair", "Leather", -150.0, true));
            Assert.Throws<Exception>(() => new Table("Dining Table", "Wood", -300.0, "Rectangle"));
        }

        [TestMethod]
        public void TestChairsPrice()
        {
            var chairsList = new List<Chair>
            {
                new Chair("Office Chair", "Leather", 150.0, true),
                new Chair("Office", "Leather", 100.0, false),
                new Chair("Oe Chair", "Leather", 200.0, true),
                new Chair("Office Chr", "Leather", 300.0, false)
            };
            var analysis = new FurnitureAnalysis();

            var SA = analysis.GetAveragePriceChairs(chairsList);

            double expectedTotalLeather = 750.0/4.0;
            Assert.AreEqual(expectedTotalLeather, SA);
        }

        [TestMethod]
        public void TestGetTotalPriceByMaterial()
        {
            var furnitureList = new List<Furniture>
            {
                new Chair("Office Chair", "Leather", 150.0, true),
                new Table("Dining Table", "Wood", 300.0, "Rectangle"),
                new Chair("Gaming Chair", "Fabric", 200.0, false),
                new Table("Coffee Table", "Glass", 100.0, "Round"),
                new Chair("Dining Chair", "Wood", 80.0, false)
            };

            var analysis = new FurnitureAnalysis();

            var expectedTotalLeather = 150.0;
            var expectedTotalWood = 380.0;
            var expectedTotalFabric = 200.0;
            var expectedTotalGlass = 100.0;

            var realTotalLeather = analysis.GetTotalPriceByMaterial(furnitureList, "Leather");
            var realTotalWood = analysis.GetTotalPriceByMaterial(furnitureList, "Wood");
            var realTotalFabric = analysis.GetTotalPriceByMaterial(furnitureList, "Fabric");
            var realTotalGlass = analysis.GetTotalPriceByMaterial(furnitureList, "Glass");

            Assert.AreEqual(expectedTotalLeather, realTotalLeather);
            Assert.AreEqual(expectedTotalWood, realTotalWood);
            Assert.AreEqual(expectedTotalFabric, realTotalFabric);
            Assert.AreEqual(expectedTotalGlass, realTotalGlass);
        }
    }
}
