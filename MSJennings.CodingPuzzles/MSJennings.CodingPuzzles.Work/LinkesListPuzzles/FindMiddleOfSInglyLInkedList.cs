namespace MSJennings.CodingPuzzles.Work.LinkesListPuzzles
{
    public class FindMiddleOfSinglyLInkedList
    {
        public SinglyLinkedListNode<T> GetResult<T>(SinglyLinkedList<T> list)
        {
            var slow = list.Root;
            var fast = list.Root;

            while (fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
        }
    }
}
