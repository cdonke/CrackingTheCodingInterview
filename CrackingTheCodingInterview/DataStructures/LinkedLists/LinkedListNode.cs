using System.Diagnostics;

namespace CrackingTheCodingInterview.DataStructures.LinkedLists
{
    [DebuggerStepThrough]
    [DebuggerDisplay("{value}")]
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.value = value;
        }

        public T value { get; set; }
        public LinkedListNode<T> next { get; set; }
    }

    [DebuggerStepThrough]
    [DebuggerDisplay("{value}")]
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        { 
            this.value = value;
        }

        public T value { get; set; }
        public DoublyLinkedListNode<T> next { get; set; }
        public DoublyLinkedListNode<T> previous { get; set; }
    }
}
