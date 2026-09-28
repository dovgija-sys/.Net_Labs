using program_lab2.Classes;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        // Test method for Task1 class
        [TestMethod]
        public void Task1_AllEven_ReturnsProduct()
        {
            var calc = new Calculation_Task1(2, 4, 6);
            var expected = 48;
            var actual = calc.Calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_NotAllEven_SquareOfSum()
        {
            var calc = new Calculation_Task1(1, 2, 3);
            var expected = 36;
            var actual = calc.Calculate();
            Assert.AreEqual(expected, actual);
        }

        // Test method for Task2 class
        [TestMethod]
        public void Task2_AGreaterThanB_ThrowsException()
        {
            var calc = new Calculation_Task2(10, 5);
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.CalculateSum());
        }

        [TestMethod]
        public void Task2_ValidRange_ReturnsCorrectSum()
        {
            var calc = new Calculation_Task2(1, 40);
            var expected = 38;
            var actual = calc.CalculateSum();
            Assert.AreEqual(expected, actual);
        }

        // Test method for Task3 class
        [TestMethod]
        public void RightTriangle_CalculatesCorrectly()
        {
            var triangle = new Calculation_Task3(3, 4);

            Assert.AreEqual(5, triangle.GetHypotenuse(), 0.001);
            Assert.AreEqual(1, triangle.GetInscribedRadius(), 0.001);
            Assert.AreEqual(36.869, triangle.GetAngleA(), 0.01);
            Assert.AreEqual(53.130, triangle.GetAngleB(), 0.01);
        }
    }
}
