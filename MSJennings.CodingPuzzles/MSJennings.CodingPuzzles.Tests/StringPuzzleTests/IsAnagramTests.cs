using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.StringPuzzles;

namespace MSJennings.CodingPuzzles.Tests.StringPuzzleTests
{
    [TestClass]
    public class IsAnagramTests
    {
        [DataTestMethod]
        [DataRow("iceman", "cinema", true)]
        [DataRow("dog", "cat", false)]
        [DataRow("moon", "mon", false)]
        public void GetResult_ShouldReturnCorrectResult(string s1, string s2, bool expectedResult)
        {
            // Arrange
            var sut = new IsAnagram();

            // Act
            var result = sut.GetResult(s1, s2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Result is incorrect");
        }
    }
}
