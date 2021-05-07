using CrackingTheCodingInterview.DataStructures.StacksAndQueues;
using CrackingTheCodingInterview.StacksAndQueues.StackMin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.Tests.StacksAndQueues
{
    [TestClass]
    public class StackMinTests_FirstTry : DataStructures.StacksAndQueues.MyStackTests<StackMin_FirstTry>
    {
        [TestMethod]
        [DataRow(new[] { 8, 5, 3, 6, 8, 0, 2, 5 }, 0)]
        [DataRow(new[] { 8, 5, 3, 6, 8, 2, 5 }, 2)]
        public void Min(int[] data, int expected)
        {
            foreach (var item in data)
            {
                stack.Push(item);
            }

            var actual = stack.Min;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(new[] { 8, 5, 3, 6, 8, 0, 2, 5 }, 3)]
        public void Pop_Min(int[] data, int expected)
        {
            foreach (var item in data)
            {
                stack.Push(item);
            }

            Assert.AreEqual(data.Length, stack.Count);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            var actual = stack.Min;

            Assert.AreEqual(data.Length - 3, stack.Count);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(StackEmptyException))]
        public void Pop_Min_Empty()
        {
            var actual = stack.Min;
        }

    }

    [TestClass]
    public class StackMinTests_SecondTry : DataStructures.StacksAndQueues.MyStackTests<StackMin_SecondTry>
    {
        [TestMethod]
        [DataRow(new[] { 8, 5, 3, 6, 8, 0, 2, 5 }, 0)]
        [DataRow(new[] { 8, 5, 3, 6, 8, 2, 5 }, 2)]
        public void Min(int[] data, int expected)
        {
            foreach (var item in data)
            {
                stack.Push(item);
            }

            var actual = stack.Min;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(new[] { 8, 5, 3, 6, 8, 0, 2, 5 }, 3)]
        public void Pop_Min(int[] data, int expected)
        {
            foreach (var item in data)
            {
                stack.Push(item);
            }

            Assert.AreEqual(data.Length, stack.Count);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            var actual = stack.Min;

            Assert.AreEqual(data.Length - 3, stack.Count);
            Assert.AreEqual(expected, actual);
        }
    }
}
