using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.Hashtable
{
    [TestClass]
    public class MyHashtableTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Add_DefaultConstructor(int[] items, int capacity)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>();
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", i);
            }

            Assert.AreEqual(items.Length, hashtable.Count);
        }


        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Add(int[] items, int capacity)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", i);
            }

            Assert.AreEqual(items.Length, hashtable.Count);
        }


        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Get(int[] items, int capacity)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            int actual = hashtable["item 10"];
            Assert.AreEqual(10, actual);

            actual = hashtable["item 7"];
            Assert.AreEqual(7, actual);

            actual = hashtable["item 2"];
            Assert.AreEqual(2, actual);

            actual = hashtable["item 1000"];
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Get_Indexer(int[] items, int capacity)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            int actual = hashtable["item 10"];
            Assert.AreEqual(10, actual);

            actual = hashtable["item 7"];
            Assert.AreEqual(7, actual);

            actual = hashtable["item 2"]; 
            Assert.AreEqual(2, actual);

            actual = hashtable["item 1000"];
            Assert.AreEqual(0, actual);
        }


        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Delete(int[] items, int capacity)
        {
            int item;
            bool success;
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            int n = items.Length;
            for (int i = 0; i < n; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
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
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Delete_Twice(int[] items, int capacity)
        {
            int item;
            bool success;
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            int n = items.Length;
            for (int i = 0; i < n; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            item = hashtable.Get("item 10");
            Assert.AreEqual(10, item);
            success = hashtable.Delete("item 10");
            Assert.AreEqual(--n, hashtable.Count);
            Assert.AreEqual(0, hashtable.Get("item 10"));
            Assert.IsTrue(success);

            item = hashtable.Get("item 10");
            Assert.AreEqual(0, item);
            success = hashtable.Delete("item 10");
            Assert.AreEqual(n, hashtable.Count);
            Assert.AreEqual(0, hashtable.Get("item 10"));
            Assert.IsFalse(success);
        }

        [TestMethod]
        [DynamicData(nameof(Data_Update), DynamicDataSourceType.Method)]
        public void Update(int[] items, int capacity, string key, int expected)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            hashtable.Update(key, expected);
            var actual = hashtable.Get(key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data_Update), DynamicDataSourceType.Method)]
        public void Update_WithIndexer(int[] items, int capacity, string key, int expected)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            hashtable[key] = expected;
            var actual = hashtable[key];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Update_NotFound(int[] items, int capacity)
        {
            int expected = 10;
            string key = Guid.NewGuid().ToString();

            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            hashtable[key] = expected;
            var actual = hashtable[key];
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Clear(int[] items, int capacity)
        {
            var hashtable = new CrackingTheCodingInterview.DataStructures.Hashtable.MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            Assert.AreEqual(items.Length, hashtable.Count);
            hashtable.Clear();
            Assert.AreEqual(0, hashtable.Count);
        }

        public static IEnumerable<object[]> Data()
        {
            return CrackingTheCodingInterview.ArraysAndStrings.Hashtable.HashtableBenchmark.Data();
        }
        public static IEnumerable<object[]> Data_Update()
        {
            Random r = new Random();

            foreach (var data in Data())
            {
                int[] numbers = data[0] as int[];
                object capacity = data[1];
                var max_data = numbers.Length;
                int idx = r.Next(0, max_data);
                int expected = idx * 2;

                yield return new object[] { numbers, capacity, $"item {idx}", expected };
            }
        }
    }
}
