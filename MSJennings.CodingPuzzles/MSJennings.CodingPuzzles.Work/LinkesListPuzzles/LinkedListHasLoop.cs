using System;
using System.Collections.Generic;
using System.Text;

namespace MSJennings.CodingPuzzles.Work.LinkesListPuzzles
{
    public class LinkedListHasLoop
    {
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
    }
}
