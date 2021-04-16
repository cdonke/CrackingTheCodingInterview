using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CrackingTheCodingInterview.Tests.DataStructures.ArrayList
{
    [TestClass]
    public class ArrayListTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Add(int[] items, int capacity)
        {
            var arrayList = new CrackingTheCodingInterview.DataStructures.ArrayList.MyArrayList<int>(capacity);
            foreach (var item in items)
                arrayList.Add(item);

            Assert.AreEqual(items.Length, arrayList.Count);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void AddRange_Array(int[] items, int capacity)
        {
            var arrayList = new CrackingTheCodingInterview.DataStructures.ArrayList.MyArrayList<int>(capacity);
            arrayList.AddRange(items);

            Assert.AreEqual(items.Length, arrayList.Count);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void AddRange_List(IEnumerable<int> items, int capacity)
        {
            var arrayList = new CrackingTheCodingInterview.DataStructures.ArrayList.MyArrayList<int>(capacity);
            arrayList.AddRange(items);

            Assert.AreEqual(items.Count(), arrayList.Count);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Clear(int[] items, int capacity)
        {
            var arrayList = new CrackingTheCodingInterview.DataStructures.ArrayList.MyArrayList<int>();
            arrayList.AddRange(items);
            arrayList.Clear();

            Assert.AreEqual(0, arrayList.Count);
        }


        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { Enumerable.Range(0, 10).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 100).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 1000).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 10000).ToArray(), 1000 };
        }
    }
}
