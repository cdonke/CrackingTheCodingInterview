using CrackingTheCodingInterview.DataStructures.ArrayList;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.StringBuilder
{
    public class MyStringBuilder
    {
        private readonly int _capacity;
        //private MyArrayList<char> _collection;
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
            for (int i = 0; i < _collection.Length; i++)
            {
                _collection[i] = default(char);
            }
        }

        public int Count
            => _position;

        public override string ToString()
        {
            var array = new char[_position];
            copyArray(_collection, array, 0, _position);

            return new string(array);
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
