using NUnit.Framework;
using Topic_7_Structs_UnitTests;

namespace PirmasTestas1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingTaxCalculator()
        {
            //Arrange (Duomenų mock'as)
            decimal income = 10000;
            decimal expectedResult = 1;

            //Act (Callinam methoda)
            decimal actualResult = Program.CalculateTax(income);

            //Assert (Lyginam)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}