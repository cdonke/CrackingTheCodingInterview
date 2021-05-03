using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.LinkedLists
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Add(int[] data)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            Assert.AreEqual(data.Length, ll.Count);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(data[i], ll[i]);
            }
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 2, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 0, new int[] { 3, 1, 2, 4, 5 })]
        public void InsertAt(int[] data, int number, int position, int[] expected)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            ll.InsertAt(number, position);

            Assert.AreEqual(expected.Length, ll.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], ll[i]);
            }
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 4)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 5)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 6)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, -1)]
        public void InsertAt_Exception(int[] data, int number, int position)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            ll.InsertAt(number, position);
        }


        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 3, 0, 2)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 30, 0, -1)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 3 }, 3, 5, 8)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 3 }, 3, 0, 2)]
        public void IndexOf(int[] data, int number, int start, int expected)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            var actual = ll.IndexOf(start, number);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 4)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 5)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 6)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, -1)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3, 16)]
        public void IndexOf_Exception(int[] data, int number, int start)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            var actual = ll.IndexOf(start, number);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 2, 3, 4, 5 })]
        public void Delete(int[] data, int toDelete, int[] expected)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            ll.Delete(toDelete);

            Assert.AreEqual(expected.Length, ll.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], ll[i]);
            }
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, -1)]
        public void Delete_Exception(int[] data, int toDelete)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            ll.Delete(toDelete);
        }


        [TestMethod]
        [DataRow(new int[] { 1, 2, 4, 5 }, 3)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 0)]
        public void Indexer(int[] data, int idx)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            var actual = ll[idx];

            Assert.AreEqual(data[idx], actual);
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 4, 5 }, -1)]
        [DataRow(new int[] { 1, 2, 4, 5 }, 10)]
        public void Indexer_Exception(int[] data, int idx)
        {
            var ll = new CrackingTheCodingInterview.DataStructures.LinkedLists.LinkedList<int>();
            foreach (var item in data)
            {
                ll.Add(item);
            }

            var actual = ll[idx];
        }
    }
}
