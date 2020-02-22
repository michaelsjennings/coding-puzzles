using System;
using System.Collections.Generic;
using System.Text;

namespace MSJennings.CodingPuzzles.Work.LinkesListPuzzles
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Root { get; set; } = null;
    }

    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }

        public SinglyLinkedListNode<T> Next { get; set; } = null;
    }
}
