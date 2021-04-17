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
        private MyArrayList<char> _collection;

        public MyStringBuilder() : this(1000, string.Empty) { }
        public MyStringBuilder(string data) : this(1000, data) { }
        public MyStringBuilder(int capacity, string data)
        {
            _capacity = capacity;
            _collection = new MyArrayList<char>(_capacity);
            Append(data);
        }
               
        public void Append(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                _collection.Add(data[i]);
            }
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
            _collection.Clear();
        }

        public int Count
            => _collection.Count;
            
        public override string ToString()
        {
            return new string(_collection.ToArray());
        }
    }
}
