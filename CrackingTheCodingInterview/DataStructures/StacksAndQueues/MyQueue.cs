using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.StacksAndQueues
{
    public class EmptyQueueException : Exception { }

    public class MyQueue<T>
    {
        private class MyQueueNode
        {

            public MyQueueNode(T value)
            {
                this.value = value;
            }
            public T value { get; set; }
            public MyQueueNode next { get; set; }
        }

        private MyQueueNode _first;
        private MyQueueNode _last;

        public int Count { get; private set; }
        public void Enqueue(T item)
        {
            var node = new MyQueueNode(item);
            if (IsEmpty)
            {
                _first = node;
                _last = _first;
            }
            else
            {
                _last.next = node;
                _last = node;
            }

            Count++;
        }

        public T Dequeue()
        {
            var data = Peek();
            _first = _first.next;
            Count--;
            
            return data;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            var data = _first.value;

            return data;
        }

        public bool IsEmpty => _first == null;
    }
}
