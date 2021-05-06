using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.LinkedLists
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> _head;

        public DoublyLinkedList() { }
        public DoublyLinkedList(T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Add(data[i]);
            }
        }

        public DoublyLinkedListNode<T> this[int element]
        {
            get
            {
                if (element < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (_head == null)
                {
                    return null;
                }

                DoublyLinkedListNode<T> current = _head;
                if (element == 0)
                {
                    return current;
                }


                for (int i = 0; i < element && current != null; i++)
                {
                    current = current.next;
                }



                return current;
            }
        }

        public int Count { get; private set; }

        public void Add(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            var currentNode = _head;
            var previousNode = _head;

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                while (currentNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }

                newNode.previous = previousNode;
                previousNode.next = newNode;
            }

            Count++;
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
                DoublyLinkedListNode<T> current = _head.next;

                for (int i = 1; i < element; i++)
                {
                    current = current.next;
                }

                current.previous.next = current.next;
                current.next.previous = current.previous;
            }

            Count--;
        }

        public int IndexOf(int start, T value)
        {
            if (start < 0 || start >= Count)
            {
                throw new IndexOutOfRangeException();
            }


            DoublyLinkedListNode<T> node = _head;
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

        public void InsertAt(T value, int position)
        {
            if (position < 0 || position >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var newNode = new DoublyLinkedListNode<T>(value);

            if (position == 0)
            {
                newNode.next = _head;
                _head = newNode;
            }
            else
            {
                DoublyLinkedListNode<T> current = _head.next;

                for (int i = 1; i < position; i++)
                {
                    current = current.next;
                }

                newNode.next = current;
                newNode.previous = current.previous;
                current.previous.next = newNode;
                current.next.previous = newNode;
            }
            Count++;
        }
    }
}
