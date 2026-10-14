using program_lab5.Logic;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace UnitTests.lab_5
{
    [TestClass]
    public class CloakRoomTests
    {
        [TestMethod]
        public void DefaultConstructor_ShouldCreateInstance_WithDefaultValues()
        {
            var cloakRoom = new CloakRoom();

            Assert.IsNotNull(cloakRoom);
            Assert.IsNull(cloakRoom.FullName);
            Assert.AreEqual(0, cloakRoom.Count);
            Assert.AreEqual(0, cloakRoom.TotalWeight);
        }

        [TestMethod]
        public void ParameterizedConstructor_ShouldSetProperties_WhenValidArguments()
        {
            string name = "Іванов Іван Іванович";
            int count = 2;
            double weight = 12.5;

            var cloakRoom = new CloakRoom(name, count, weight);

            Assert.AreEqual(name, cloakRoom.FullName);
            Assert.AreEqual(count, cloakRoom.Count);
            Assert.AreEqual(weight, cloakRoom.TotalWeight);
        }

        [TestMethod]
        public void FullName_ShouldThrowArgumentException_WhenNullOrEmpty()
        {
            var cloakRoom = new CloakRoom();
            string invalidName = string.Empty;
            Assert.Throws<ArgumentException>(() => cloakRoom.FullName = invalidName);
        }

        [TestMethod]
        public void Count_ShouldThrowArgumentOutOfRangeException_WhenZeroOrNegative()
        {
            var cloakRoom = new CloakRoom();
            int invalidCount = -2;
            Assert.Throws<ArgumentOutOfRangeException>(() => cloakRoom.Count = invalidCount);
        }

        [TestMethod]
        public void TotalWeight_ShouldThrowArgumentOutOfRangeException_WhenZeroOrNegative()
        {
            var cloakRoom = new CloakRoom();

            double invalidWeight = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => cloakRoom.TotalWeight = invalidWeight);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnPositive_WhenArgumentIsNull()
        {
            var cloakRoom = new CloakRoom("Іванов І.І.", 1, 1.0);

            int result = cloakRoom.CompareTo(null);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnZero_WhenNamesAreEqual()
        {
            var room1 = new CloakRoom("Петров П.П.", 2, 2.0);
            var room2 = new CloakRoom("Петров П.П.", 3, 3.0);

            int result = room1.CompareTo(room2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnNegative_WhenCurrentNameIsAlphabeticallyBefore()
        {
            var room1 = new CloakRoom("Антонов А.А.", 1, 1.0);
            var room2 = new CloakRoom("Борисов Б.Б.", 1, 1.0);

            int result = room1.CompareTo(room2);

            Assert.IsLessThan(0, result);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnPositive_WhenCurrentNameIsAlphabeticallyAfter()
        {
            var room1 = new CloakRoom("Васильєв В.В.", 1, 1.0);
            var room2 = new CloakRoom("Антонов А.А.", 1, 1.0);

            int result = room1.CompareTo(room2);

            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormattedString()
        {
            var cloakRoom = new CloakRoom("Шевченко Т.Г.", 3, 4.5);
            string expected = "ПІБ: Шевченко Т.Г., Кількість речей: 3, Загальна вага речей: 4,5";

            string actual = cloakRoom.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}