using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.ArrayPuzzles;

namespace MSJennings.CodingPuzzles.Tests.ArrayPuzzleTests
{
    [TestClass]
    public class ReverseArrayTests
    {
        #region Public Methods

        [TestMethod]
        public void Go_WithEvenCount_ShouldReverse()
        {
            // Arrange
            var sut = new ReverseArray();

            var arr = new[] { 1, 2, 3, 4, 5, 6 };
            var expected = new[] { 6, 5, 4, 3, 2, 1 };

            // Act
            sut.Go(arr);

            // Assert
            CollectionAssert.AreEqual(expected, arr, "Array was not correctly reversed");
        }

        [TestMethod]
        public void Go_WithOddCount_ShouldReverse()
        {
            // Arrange
            var sut = new ReverseArray();

            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new[] { 7, 6, 5, 4, 3, 2, 1 };

            // Act
            sut.Go(arr);

            // Assert
            CollectionAssert.AreEqual(expected, arr, "Array was not correctly reversed");
        }

        #endregion Public Methods
    }
}
