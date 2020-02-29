using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.IntegerPuzzles;

namespace MSJennings.CodingPuzzles.Tests.IntegerPuzzleTests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [DataTestMethod]
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(120, 21)]
        public void GetResult_ShouldReturnCorrectResult(int value, int expectedResult)
        {
            // Arrange
            var sut = new ReverseInteger();

            // Act
            var result = sut.GetResult(value);

            // Assert
            Assert.AreEqual(expectedResult, result, "Result is not correct");
        }
    }
}
