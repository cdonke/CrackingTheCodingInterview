using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.ArrayList
{
    public class MyArrayList<T>
    {
        private readonly int _factor;
        private int _capacity;
        private T[] _collection;
        private int _count;

        public MyArrayList() : this(1000, 2) { }
        public MyArrayList(int capacity) : this(capacity, 2) { }
        public MyArrayList(int capacity, int factor)
        {
            _factor = factor;
            _capacity = capacity;
            _collection = new T[_capacity];
        }

        public int Count
            => _count;


        public void Add(T item)
        {
            _collection[_count++] = item;
            if (_count == _capacity)
            {
                Resize();
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        public void AddRange(T[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        public void Clear()
        {
            for (; _count > 0; _count--)
            {
                _collection[_count] = default(T);
            }
        }

        public T[] ToArray()
        {
            T[] result = new T[_count];
            for (int i = 0; i < _count; i++)
            {
                result[i] = _collection[i];
            }

            return result;
        }

        private void Resize()
        {
            var capacity = _capacity * _factor;
            var collection = new T[capacity];

            for (int i = 0; i < _count; i++)
            {
                collection[i] = _collection[i];
            }

            _capacity = capacity;
            _collection = collection;
        }
    }
}
