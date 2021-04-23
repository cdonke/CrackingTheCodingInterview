using CrackingTheCodingInterview.DataStructures.ArrayList;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.StringBuilder.v2
{
    public class MyStringBuilder
    {
        private int _capacity;
        private char[] _collection;
        private int _position;

        public MyStringBuilder() : this(1000, string.Empty) { }
        public MyStringBuilder(string data) : this(1000, data) { }
        public MyStringBuilder(int capacity, string data)
        {
            _capacity = capacity;
            _collection = new char[_capacity];
            _position = 0;
            Append(data);
        }

        public void Append(string data)
        {
            if (_position+data.Length > _capacity)
            {
                Resize(_position + data.Length);
            }
            copyArray(data, _collection, _position, data.Length);

            _position += data.Length;
        }
        public void AppendLine()
        {
            AppendLine(string.Empty);
        }
        public void AppendLine(string data)
        {
            Append(data);
            Append(Environment.NewLine);
        }
        public void Clear()
        {
            for (; _position > 0; _position--)
            {
                _collection[_position] = default(char);
            }
        }

        public int Count
            => _position;

        public override string ToString()
        {
            if (_position == 0)
            {
                return string.Empty;
            }

            var array = new char[_position];
            copyArray(_collection, array, 0, _position);

            return new string(array);
        }

        private void Resize(int min_size)
        {
            int capacity = _capacity;
            while (capacity < min_size)
            {
                capacity += capacity;
            }

            char[] collection = new char[capacity];
            copyArray(_collection, collection, 0, _position);

            _capacity = capacity;
            _collection = collection;
        }

        private void copyArray(string src, char[] dest, int start, int length)
        {
            unsafe
            {
                fixed (char* dataChars = src)
                {
                    fixed (char* destPtr = &_collection[start])
                    {
                        Buffer.MemoryCopy(dataChars, destPtr, length * sizeof(char), length * sizeof(char));
                    }
                }
            }
        }
        private void copyArray(char[] src, char[] dest, int start, int length)
        {
            unsafe
            {
                fixed (char* srcPtr = src)
                {
                    fixed (char* destPtr = &dest[start])
                    {
                        Buffer.MemoryCopy(srcPtr, destPtr, (length) * sizeof(char), length * sizeof(char));
                    }
                }
            }
        }
    }
}
