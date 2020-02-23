using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.TreePuzzles;

namespace MSJennings.CodingPuzzles.Tests.TreePuzzleTests
{
    [TestClass]
    public class PostOrderRecursiveTreeTraversalTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_ShouldReturnCorrectResult()
        {
            // Arrange
            var sut = new PostOrderRecursiveTreeTraversal();

            var tree = TreePuzzleTestsHelper.GetTestTree();

            var expected = new int[] { /* ? ? ? */ };

            // Act
            var result = sut.GetResult(tree);

            // Assert

            CollectionAssert.AreEqual(expected, result, "Result is not correct");
        }

        #endregion Public Methods
    }
}
