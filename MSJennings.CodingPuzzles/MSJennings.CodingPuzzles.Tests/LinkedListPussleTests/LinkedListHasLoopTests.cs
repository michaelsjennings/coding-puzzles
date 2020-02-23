using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.LinkedListPuzzles;

namespace MSJennings.CodingPuzzles.Tests.LinkedListPussleTests
{
    [TestClass]
    public class LinkedListHasLoopTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_WithLoop_ShouldReturnTrue()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            list.Root = new SinglyLinkedListNode<int> { Value = 101 };

            var two = new SinglyLinkedListNode<int> { Value = 102 };
            list.Root.Next = two;

            var three = new SinglyLinkedListNode<int> { Value = 103 };
            two.Next = three;

            var four = new SinglyLinkedListNode<int> { Value = 104 };
            three.Next = four;

            four.Next = two;

            var sut = new LinkedListHasLoop();

            // Act
            var result = sut.GetResult(list);

            // Assert
            Assert.IsTrue(result, "Result is not correct");
        }

        [TestMethod]
        public void GetResult_WithNoLoop_ShouldReturnFalse()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            list.Root = new SinglyLinkedListNode<int> { Value = 101 };

            var two = new SinglyLinkedListNode<int> { Value = 102 };
            list.Root.Next = two;

            var three = new SinglyLinkedListNode<int> { Value = 103 };
            two.Next = three;

            var four = new SinglyLinkedListNode<int> { Value = 104 };
            three.Next = four;

            var sut = new LinkedListHasLoop();

            // Act
            var result = sut.GetResult(list);

            // Assert
            Assert.IsFalse(result, "Result is not correct");
        }

        #endregion Public Methods
    }
}
