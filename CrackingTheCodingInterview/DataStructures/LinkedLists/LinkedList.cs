using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.LinkedLists
{
    public class LinkedList<T> 
    {

        private LinkedListNode<T> _head;

        public LinkedList()
        { }

        public LinkedList(T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.Add(data[i]);
            }
        }

        public T this[int element]
        {
            get
            {
                if (element < 0 || element >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                LinkedListNode<T> current = _head;
                if (element == 0)
                {
                    return current.value;
                }


                for (int i = 0; i < element; i++)
                {
                    current = current.next;
                }



                return current.value;
            }
        }
        public int Count { get; private set; }

        public void Add(T value)
        {
            var node = new LinkedListNode<T>(value);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var current = _head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }

            Count++;
        }
        public void InsertAt(T value, int position)
        {
            if (position < 0 || position >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var newNode = new LinkedListNode<T>(value);

            if (position == 0)
            {
                newNode.next = _head;
                _head = newNode;
            }
            else
            {
                LinkedListNode<T> previous = _head,
                    current = _head.next;

                for (int i = 1; i < position; i++)
                {
                    previous = current;
                    current = current.next;
                }

                newNode.next = current;
                previous.next = newNode;
            }
            Count++;
        }

        public int IndexOf(int start, T value)
        {
            if (start < 0 || start >= Count)
            {
                throw new IndexOutOfRangeException();
            }


            LinkedListNode<T> node = _head;
            int i;
            for (i = 0; i < Count; i++)
            {
                if (i < start)
                {
                    node = node.next;
                    continue;
                }

                if (node.value.Equals(value))
                {
                    return i;
                }
                else
                {
                    node = node.next;
                }
            }

            return -1;
        }

        public void Delete(int element)
        {
            if (element < 0 || element >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (element == 0)
            {
                _head = _head.next;
            }
            else
            {
                LinkedListNode<T> previous = _head,
                    current = _head.next;

                for (int i = 1; i < element; i++)
                {
                    previous = current;
                    current = current.next;
                }

                previous.next = current.next;
            }

            Count--;
        }

    }
}
