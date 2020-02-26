using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.ArrayPuzzles;
using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Tests.ArrayPuzzleTests
{
    [TestClass]
    public class FindPairsYieldingSumTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_ShouldReturnCorrectResult()
        {
            // Arrange
            var sut = new FindPairsYieldingSum();

            var arr = new[] { 0, 14, -3, 4, 7, 8, 3, 5, 7 };
            var sum = 11;

            IList<(int, int)> expected = new List<(int, int)>
            {
                (14, -3),
                (4, 7),
                (4, 7),
                (8, 3),
            };

            // Act
            var result = sut.GetResult(arr, sum);

            // Assert
            Assert.AreEqual(expected.Count, result.Count, "Number of result items is not correct");

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i], "Value of a result item is not correct");
            }
        }

        #endregion Public Methods
    }
}
