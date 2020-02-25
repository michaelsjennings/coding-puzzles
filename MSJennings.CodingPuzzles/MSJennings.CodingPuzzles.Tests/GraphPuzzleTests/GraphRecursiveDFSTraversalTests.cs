using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.GraphPuzzles;

namespace MSJennings.CodingPuzzles.Tests.GraphPuzzleTests
{
    [TestClass]
    public class GraphRecursiveDFSTraversalTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_ShouldReturnCorrectResult()
        {
            // Arrange
            var sut = new GraphRecursiveDFSTraversal();

            var graph = GraphPuzzleTestsHelper.GetTestGraph();

            var expected = new[] { 1, 2, 3, 7, 8, 4, 5, 6 };

            // Act
            var result = sut.GetResult(graph);

            // Assert
            CollectionAssert.AreEqual(expected, result, "Result is not correct");
        }

        #endregion Public Methods
    }
}
