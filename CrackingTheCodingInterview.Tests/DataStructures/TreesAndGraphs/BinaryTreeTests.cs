using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.TreesAndGraphs
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Insert()
        {
            var tree = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.BinaryTree<int>();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(20);
            tree.Insert(14);


        }

        [TestMethod]
        [DataRow(9, true)]
        [DataRow(5, false)]
        [DataRow(6, true)]
        [DataRow(7, true)]
        [DataRow(20, true)]
        [DataRow(21, false)]
        [DataRow(14, true)]
        [DataRow(15, false)]
        public void Find(int number, bool expected)
        {
            var tree = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.BinaryTree<int>();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(20);
            tree.Insert(14);

            var actual = tree.Find(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
