using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.StacksAndQueues
{
    public class StackEmptyException : Exception { }
    public class MyStack<T>
    {
        protected class StackNode
        {
            public StackNode(T value)
            {
                this.value = value;
            }

            public T value { get; set; }
            public StackNode next { get; set; }
        }
        
        protected StackNode _top;

        public int Count { get; private set; }

        protected void Push(StackNode node)
        {
            node.next = _top;
            _top = node;
            Count++;
        }
        public virtual void Push(T value)
        {
            var node = new StackNode(value);
            Push(node);
        }

        public virtual T Pop()
        {
            if (IsEmpty)
            {
                throw new StackEmptyException();
            }

            T value = _top.value;
            _top = _top.next;

            Count--;
            return value;
        }

        public virtual T Peek()
        {
            if (IsEmpty)
            {
                throw new StackEmptyException();
            }

            return _top.value;
        }

        public bool IsEmpty => _top == null;
    }
}
