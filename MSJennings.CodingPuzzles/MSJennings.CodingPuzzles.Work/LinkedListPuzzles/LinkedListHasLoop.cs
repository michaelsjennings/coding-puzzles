using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.LinkedListPuzzles
{
    public class LinkedListHasLoop
    {
        #region Public Methods

        public bool GetResult<T>(SinglyLinkedList<T> list)
        {
            var visited = new HashSet<SinglyLinkedListNode<T>>();

            var cur = list.Root;

            visited.Add(cur);

            while (cur.Next != null)
            {
                cur = cur.Next;

                if (visited.Contains(cur))
                {
                    return true;
                }

                visited.Add(cur);
            }

            return false;
        }

        #endregion Public Methods
    }
}
