using CrackingTheCodingInterview.DataStructures.StacksAndQueues;
using Microsoft.Diagnostics.Runtime.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.StacksAndQueues.StackMin
{

    public class StackMin_FirstTry : DataStructures.StacksAndQueues.MyStack<int>
    {
        private StackNode _min;

        public override void Push(int value)
        {
            var node = new StackNode(value);
            if (_min == null)
            {
                _min = node;
            }
            else
            {
                if (_min.value >= value)
                {
                    _min = node;
                }
            }

            Push(node);
        }

        public override int Pop()
        {
            var value = base.Pop();
            if (_min.value == value)
            {
                FindNewMin();
            }

            return value;
        }

        private void FindNewMin()
        {
            var current = _top;
            var min = _top;
            while (current != null)
            {
                if (current.value < min.value && !object.ReferenceEquals(current, min))
                {
                    min = current;
                }

                current = current.next;
            }

            _min = min;
        }

        public int Min
        {
            get
            {
                if (_min == null)
                {
                    throw new StackEmptyException();
                }

                return _min.value;
            }
        }
    }

    public class StackMin_SecondTry : DataStructures.StacksAndQueues.MyStack<int>
    {
        private class MinStack : MyStack<int>
        {
            public override int Peek()
            {
                if (IsEmpty)
                {
                    return int.MaxValue;
                }

                return _top.value;
            }
        }
        private MinStack _mins = new MinStack();

        public override void Push(int value)
        {
            var node = new StackNode(value);
            if (_mins.Peek() > value)
            {
                _mins.Push(value);
            }

            Push(node);
        }

        public override int Pop()
        {
            var value = base.Pop();
            if (_mins.Peek() == value)
            {
                _mins.Pop();
            }

            return value;
        }


        public int Min
        {
            get
            {
                return _mins.Peek();
            }
        }
    }
}
