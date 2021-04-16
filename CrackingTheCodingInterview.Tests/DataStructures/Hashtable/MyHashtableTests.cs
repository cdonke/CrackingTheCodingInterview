using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.Hashtable
{
    [TestClass]
    public class MyHashtableTests
    {
        [TestMethod]
        public void Add()
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(5);
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                hashtable.Add($"item {i}", i);
            }

            Assert.AreEqual(n, hashtable.Count);
        }

        [TestMethod]
        public void Get()
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(5);
            for (int i = 0; i < 20; i++)
            {
                hashtable.Add($"item {i}", i);
            }

            int expected = hashtable.Get("item 10");
            Assert.AreEqual(10, 10);

            expected = hashtable.Get("item 7");
            Assert.AreEqual(7, 7);

            expected = hashtable.Get("item 2");
            Assert.AreEqual(2, 2);

            expected = hashtable.Get("item 1000");
            Assert.AreEqual(0, 00);
        }

        [TestMethod]
        public void Delete()
        {
            int item;
            bool success;
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(5);
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                hashtable.Add($"item {i}", i);
            }

            item = hashtable.Get("item 10");
            Assert.AreEqual(10, item);
            success = hashtable.Delete("item 10");
            Assert.AreEqual(--n, hashtable.Count);
            Assert.AreEqual(0, hashtable.Get("item 10"));
            Assert.IsTrue(success);

            item = hashtable.Get("item 7");
            Assert.AreEqual(7, item);
            success = hashtable.Delete("item 7");
            Assert.AreEqual(--n, hashtable.Count);
            Assert.AreEqual(0, hashtable.Get("item 7"));
            Assert.IsTrue(success);

            item = hashtable.Get("item 0");
            Assert.AreEqual(0, item);
            success = hashtable.Delete("item 0");
            Assert.AreEqual(--n, hashtable.Count);
            Assert.AreEqual(0, hashtable.Get("item 0"));
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Update()
        {
            int expected = 20;
            string key = "item 10";
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>();
            for (int i = 0; i < 20; i++)
            {
                hashtable.Add($"item {i}", i);
            }

            hashtable.Update(key, expected);
            var actual = hashtable.Get(key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Update_WithIndexer()
        {
            int expected = 20;
            string key = "item 10";
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>();
            for (int i = 0; i < 20; i++)
            {
                hashtable.Add($"item {i}", i);
            }

            hashtable[key] = expected;
            var actual = hashtable.Get(key);
            Assert.AreEqual(expected, actual);
        }
    }
}
