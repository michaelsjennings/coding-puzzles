using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.StringPuzzles;

namespace MSJennings.CodingPuzzles.Tests.StringPuzzleTests
{
    [TestClass]
    public class IsPalindromeTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_WithNoPalindrome_ShouldReturnFalse()
        {
            // Arrange
            var sut = new IsPalindrome();

            var s = "abcdba";

            // Act
            var result = sut.GetResult(s);

            // Assert
            Assert.IsFalse(result, "Result is incorrect");
        }

        [TestMethod]
        public void GetResult_WithYesPalindrome_ShouldReturnTrue()
        {
            // Arrange
            var sut = new IsPalindrome();

            var s = "abcba";

            // Act
            var result = sut.GetResult(s);

            // Assert
            Assert.IsTrue(result, "Result is incorrect");
        }

        #endregion Public Methods
    }
}
