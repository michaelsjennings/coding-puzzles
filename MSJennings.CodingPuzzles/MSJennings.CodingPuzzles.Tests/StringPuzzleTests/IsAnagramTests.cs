using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.StringPuzzles;

namespace MSJennings.CodingPuzzles.Tests.StringPuzzleTests
{
    [TestClass]
    public class IsAnagramTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_WithNoAnagram_ShouldReturnFalse()
        {
            // Arrange
            var sut = new IsAnagram();

            var s = "abcdba";

            // Act
            var result = sut.GetResult(s);

            // Assert
            Assert.IsFalse(result, "Result is incorrect");
        }

        [TestMethod]
        public void GetResult_WithYesAnagram_ShouldReturnTrue()
        {
            // Arrange
            var sut = new IsAnagram();

            var s = "abcba";

            // Act
            var result = sut.GetResult(s);

            // Assert
            Assert.IsTrue(result, "Result is incorrect");
        }

        #endregion Public Methods
    }
}
