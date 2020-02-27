using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.SortPuzzles;
using System.Linq;

namespace MSJennings.CodingPuzzles.Tests.SortPuzzleTests
{
    [TestClass]
    public class SelectionSortTests
    {
        #region Public Methods

        [TestMethod]
        public void Sort_ShouldSortCorrectly()
        {
            // Arrange
            var sut = new SelectionSort();

            var size = 1000;
            var arr = SortPuzzleTestsHelper.GetRandomIntArray(size);

            var list = arr.ToList();
            list.Sort();
            var expected = list.ToArray();

            // Act
            sut.Sort(arr);

            // Assert
            CollectionAssert.AreEqual(expected, arr);
        }

        #endregion Public Methods
    }
}
