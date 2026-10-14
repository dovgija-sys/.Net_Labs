using program_lab5.Logic;

namespace UnitTests.lab_5
{
    [TestClass]
    public class CloakRoomFullNameComparerTests
    {
        [TestMethod]
        public void Compare_ShouldReturnZero_WhenFirstArgumentIsNull()
        {
            var comparer = new CloakRoomFullNameComparer();
            var room2 = new CloakRoom("Іванов І.І.", 1, 1.0);

            int result = comparer.Compare(null, room2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Compare_ShouldReturnZero_WhenSecondArgumentIsNull()
        {
            var comparer = new CloakRoomFullNameComparer();
            var room1 = new CloakRoom("Іванов І.І.", 1, 1.0);

            int result = comparer.Compare(room1, null);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Compare_ShouldReturnZero_WhenBothArgumentsAreNull()
        {
            var comparer = new CloakRoomFullNameComparer();

            int result = comparer.Compare(null, null);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Compare_ShouldReturnZero_WhenNamesAreEqual_IgnoringCase()
        {
            var comparer = new CloakRoomFullNameComparer();
            var room1 = new CloakRoom("Петров П.П.", 2, 2.0);
            var room2 = new CloakRoom("петров п.п.", 3, 3.0);

            int result = comparer.Compare(room1, room2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Compare_ShouldReturnNegative_WhenFirstFullNameIsAlphabeticallyBefore()
        {
            var comparer = new CloakRoomFullNameComparer();
            var room1 = new CloakRoom("Антонов А.А.", 1, 1.0);
            var room2 = new CloakRoom("Борисов Б.Б.", 1, 1.0);

            int result = comparer.Compare(room1, room2);

            Assert.IsLessThan(0, result);
        }

        [TestMethod]
        public void Compare_ShouldReturnPositive_WhenFirstFullNameIsAlphabeticallyAfter()
        {
            // Arrange
            var comparer = new CloakRoomFullNameComparer();
            var room1 = new CloakRoom("Васильєв В.В.", 1, 1.0);
            var room2 = new CloakRoom("Антонов А.А.", 1, 1.0);

            // Act
            int result = comparer.Compare(room1, room2);

            // Assert
            Assert.IsGreaterThan(0, result);
        }
    }
}
