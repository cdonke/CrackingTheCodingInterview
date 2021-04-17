using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.Hashtable
{
    public class MyHashtable<TInput>
    {
        private static object _resizeLock = new object();
        private int _count;
        private int _length;
        private int _factor;
        private Node[] _nodes;

        private class Node
        {
            public TInput value { get; set; }
            public string key { get; set; }
            public Node next { get; set; }
        }

        public MyHashtable() : this(100) { }
        public MyHashtable(int capacity)
        {
            _factor = 2;
            _length = capacity;
            _nodes = new Node[_length];
        }

        public int Count => _count;

        public void Add(string key, TInput value)
        {
            Add(_nodes, _length, key, value);
            _count++;
        }

        public TInput this[string key]
        {
            get => Get(key);
            set => Update(key, value);
        }

        public void Clear()
        {
            // Perhaps persist the initial _length, and when cleared, resize it to the original.
            // Other option, is to loop throughout the array, setting null, instead of allocating a new object.

            _nodes = new Node[_length];
            _count = 0;
        }

        private void Add(Node[] collection, int length, string key, TInput value)
        {
            var node = new Node
            {
                key = key,
                value = value
            };

            var hash = HashKey(key, length);
            if (collection[hash] != null)
            {
                var currentNode = collection[hash];
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = node;
            }
            else
            {
                collection[hash] = node;
            }

            if (_count > length * _factor)
            {
                lock (_resizeLock)
                    Resize();
            }
        }
        public TInput Get(string key)
        {
            var hash = HashKey(key, _length);
            var currentNode = _nodes[hash];
            while (currentNode != null && !currentNode.key.Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                currentNode = currentNode.next;
            }

            return currentNode != null ? currentNode.value : default(TInput);
        }
        public void Update(string key, TInput value)
        {
            var hash = HashKey(key, _length);
            var currentNode = _nodes[hash];
            while (currentNode != null && !currentNode.key.Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                currentNode = currentNode.next;
            }

            if (currentNode != null)
            {
                currentNode.value = value;
            }
        }
        public bool Delete(string key)
        {
            int hash = HashKey(key, _length);
            Node previousNode = null,
                currentNode = _nodes[hash];

            while (currentNode != null && !currentNode.key.Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }

            if (currentNode == null)
            {
                return false;
            }
            else
            {
                if (previousNode != null)
                {
                    previousNode.next = currentNode.next;
                }
                else
                {
                    _nodes[hash] = currentNode.next;
                }
                _count--;
                return true;
            }
        }

        private void Resize()
        {
            int new_size = _length * _factor;
            Node[] newNodes = new Node[new_size];

            Node currentNode;
            for (int i = 0; i < _nodes.Length; i++)
            {
                currentNode = _nodes[i];
                while (currentNode != null)
                {
                    Add(newNodes, new_size, currentNode.key, currentNode.value);
                    currentNode = currentNode.next;
                }
            }

            _length = new_size;
            _nodes = newNodes;
        }
        private int HashKey(string key, int length)
        {
            unchecked
            {
                int hash = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    hash += (key[i] * 72) ^ i;
                }

                return hash % length;
            }
        }
    }
}
