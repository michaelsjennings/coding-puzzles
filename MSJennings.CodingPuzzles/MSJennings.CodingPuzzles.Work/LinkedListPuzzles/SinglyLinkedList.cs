namespace MSJennings.CodingPuzzles.Work.LinkedListPuzzles
{
    public class SinglyLinkedList<T>
    {
        #region Public Properties

        public SinglyLinkedListNode<T> Root { get; set; } = null;

        #endregion Public Properties
    }

    public class SinglyLinkedListNode<T>
    {
        #region Public Properties

        public SinglyLinkedListNode<T> Next { get; set; } = null;

        public T Value { get; set; }

        #endregion Public Properties
    }
}
