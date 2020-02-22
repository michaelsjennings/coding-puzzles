using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.LinkesListPuzzles;

namespace MSJennings.CodingPuzzles.Tests.LinkedListPussleTests
{
    [TestClass]
    public class FindMiddleOfSinglyLinkedListTests
    {
        [TestMethod]
        public void GetResult_ShouldReturnCorrectResult()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            list.Root = new SinglyLinkedListNode<int>();
            list.Root.Value = 101;

            var prev = list.Root;

            var numberOfNodes = 6;
            SinglyLinkedListNode<int> middleNode = null;
            int middleIndex =
                numberOfNodes % 2 == 0 ?
                numberOfNodes / 2 - 1 :
                numberOfNodes / 2;

            for (var i = 1; i < numberOfNodes; i++)
            {
                var next = new SinglyLinkedListNode<int>();
                next.Value = list.Root.Value + i + 1;

                if (i == middleIndex)
                {
                    middleNode = next;
                }

                prev.Next = next;

                prev = next;
            }

            var sut = new FindMiddleOfSinglyLInkedList();

            // Act
            var result = sut.GetResult(list);

            // Assert
            Assert.AreEqual(middleNode.Value, result.Value, "Result is not correct");
        }
    }
}
