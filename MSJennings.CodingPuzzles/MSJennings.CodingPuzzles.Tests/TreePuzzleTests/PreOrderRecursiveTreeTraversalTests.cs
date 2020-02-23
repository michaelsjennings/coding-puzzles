using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.TreePuzzles;

namespace MSJennings.CodingPuzzles.Tests.TreePuzzleTests
{
    [TestClass]
    public class PreOrderRecursiveTreeTraversalTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_ShouldReturnCorrectResult()
        {
            // Arrange
            var sut = new PreOrderRecursiveTreeTraversal();

            var tree = TreePuzzleTestsHelper.GetTestTree();

            var expected = new[] { 1, 2, 4, 5, 7, 3, 6 };

            // Act
            var result = sut.GetResult(tree);

            // Assert

            CollectionAssert.AreEqual(expected, result, "Result is not correct");
        }

        #endregion Public Methods
    }
}
