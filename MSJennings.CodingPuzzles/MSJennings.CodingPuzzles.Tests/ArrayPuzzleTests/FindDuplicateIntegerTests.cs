using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.ArrayPuzzles;

namespace MSJennings.CodingPuzzles.Tests.ArrayPuzzleTests
{
    [TestClass]
    public class FindDuplicateIntegerTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_WithArray_ReturnsCorrectResult()
        {
            // Arrange
            var arr = new[] { 3, 5, 6, 2, 4, 7, 1, 2 };
            var sut = new FindDuplicateInteger();

            // Act
            var result = sut.GetResult(arr);

            // Assert
            CollectionAssert.AreEquivalent(new[] { 2 }, result);
        }

        #endregion Public Methods
    }
}
