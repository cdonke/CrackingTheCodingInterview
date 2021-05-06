using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.StacksAndQueues
{
    [TestClass]
    public class MyQueueTests
    {
        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 10)]
        public void Add(int[] data, int expectedCount)
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            foreach (var item in data)
            {
                queue.Enqueue(item);
            }

            Assert.AreEqual(expectedCount, queue.Count);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(data[i], queue.Dequeue());
            }
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 10)]
        public void Pop(int[] data, int expectedCount)
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            foreach (var item in data)
            {
                queue.Enqueue(item);
            }

            Assert.AreEqual(expectedCount, queue.Count);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(expectedCount - 3, queue.Count);
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 1)]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1)]
        public void Peek(int[] data, int expected)
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            foreach (var item in data)
            {
                queue.Enqueue(item);
            }

            var actual = queue.Peek();
            Assert.AreEqual(data.Length, queue.Count);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, false)]
        [DataRow(new int[0], true)]
        public void IsEmpty(int[] data, bool expected)
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            foreach (var item in data)
            {
                queue.Enqueue(item);
            }

            Assert.AreEqual(expected, queue.IsEmpty);
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(CrackingTheCodingInterview.DataStructures.StacksAndQueues.EmptyQueueException))]
        public void Peek_Exception()
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            queue.Peek();
        }


        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(CrackingTheCodingInterview.DataStructures.StacksAndQueues.EmptyQueueException))]
        public void Pop_Exception()
        {
            var queue = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyQueue<int>();
            queue.Dequeue();
        }
    }
}
