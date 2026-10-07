using program_lab3.Classes;
using program_lab3.Interfaces;
using System.Collections.ObjectModel;

namespace UnitTests.lab_4
{
    [TestClass]
    public class UnitTest_lab4
    {
        [TestMethod]
        public void TestWardrobeImplementsInterfaces()
        {
            var wardrobe = new Wardrobe("Wardrobe", "Wood", 500.0, 3);

            Assert.IsInstanceOfType<IFurniture>(wardrobe);
            Assert.IsInstanceOfType<IInstructable>(wardrobe);
        }

        [TestMethod]
        public void TestWardrobeInvalidValues()
        {
            Assert.Throws<Exception>(() => new Wardrobe("Wardrobe", "Wood", -1.0, 2));
            Assert.Throws<Exception>(() => new Wardrobe("Wardrobe", "Wood", 100.0, 0));
        }

        [TestMethod]
        public void TestWardrobeInstructionsContainDoors()
        {
            IInstructable wardrobe = new Wardrobe("Wardrobe", "Wood", 500.0, 3);

            StringAssert.Contains(wardrobe.GetAssemblyInstructions(), "3");
        }

        [TestMethod]
        public void TestPolymorphismAssemblyAndClean()
        {
            List<IFurniture> items =
            [
                new Table("Table", "Wood", 300.0, "Round"),
                new Chair("Chair", "Wood", 80.0, true),
                new Wardrobe("Wardrobe", "Wood", 500.0, 2)
            ];

            foreach (IFurniture item in items)
            {
                Assert.IsFalse(string.IsNullOrEmpty(item.Assembly()));
                Assert.IsFalse(string.IsNullOrEmpty(item.Clean()));
            }
            StringAssert.Contains(items[0].Assembly(), "столу");
            StringAssert.Contains(items[1].Assembly(), "стільця");
            StringAssert.Contains(items[2].Assembly(), "шафи");
        }

        [TestMethod]
        public void TestOnlyInstructableAreSelected()
        {
            List<IFurniture> items =
            [
                new Table("Table", "Wood", 300.0, "Round"),
                new Chair("Chair", "Wood", 80.0, false),
                new Wardrobe("Wardrobe", "Wood", 500.0, 2)
            ];

            var instructable = items.OfType<IInstructable>().ToList();

            Assert.HasCount(2, instructable);
        }

        [TestMethod]
        public void TestTotalPriceByMaterialThroughInterface()
        {
            IFurnitureAnalysis analysis = new FurnitureAnalysis();
            ObservableCollection<IFurniture> items =
            [
                new Table("Table", "Wood", 300.0, "Round"),
                new Chair("Chair", "Wood", 80.0, false),
                new Wardrobe("Wardrobe", "Wood", 500.0, 2),
                new Wardrobe("Wardrobe", "Metal", 700.0, 2)
            ];

            Assert.AreEqual(880.0, analysis.GetTotalPriceByMaterial(items, "Wood"));
            Assert.AreEqual(700.0, analysis.GetTotalPriceByMaterial(items, "Metal"));
            Assert.AreEqual(0.0, analysis.GetTotalPriceByMaterial(items, "Glass"));
        }
    }
}
