using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.StacksAndQueues
{
    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 10)]
        public void Add(int[] data, int expectedCount)
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            foreach (var item in data)
            {
                stack.Push(item);
            }

            Assert.AreEqual(expectedCount, stack.Count);
            for (int i = data.Length - 1; i >= 0; i--)
            {
                Assert.AreEqual(data[i], stack.Pop());
            }
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 10)]
        public void Pop(int[] data, int expectedCount)
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            foreach (var item in data)
            {
                stack.Push(item);
            }

            Assert.AreEqual(expectedCount, stack.Count);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.AreEqual(expectedCount - 3, stack.Count);
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 0)]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
        public void Peek(int[] data, int expected)
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            foreach (var item in data)
            {
                stack.Push(item);
            }

            var actual = stack.Peek();
            Assert.AreEqual(data.Length, stack.Count);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, false)]
        [DataRow(new int[0], true)]
        public void IsEmpty(int[] data, bool expected)
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            foreach (var item in data)
            {
                stack.Push(item);
            }

            Assert.AreEqual(expected, stack.IsEmpty);
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(CrackingTheCodingInterview.DataStructures.StacksAndQueues.StackEmptyException))]
        public void Peek_Exception()
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            stack.Peek();
        }


        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(CrackingTheCodingInterview.DataStructures.StacksAndQueues.StackEmptyException))]
        public void Pop_Exception()
        {
            var stack = new CrackingTheCodingInterview.DataStructures.StacksAndQueues.MyStack<int>();
            stack.Pop();
        }
    }
}
