using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests.LinkedLists
{
    [TestClass]
    public class KthLastsTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(LinkedList<int> list, int kth, int expected)
        {
            var solution = new CrackingTheCodingInterview.LinkedLists.KthLast.KthLast();
            var actual = solution.FirstTry(list, kth, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(LinkedList<int> list, int kth, int expected)
        {
            var solution = new CrackingTheCodingInterview.LinkedLists.KthLast.KthLast();
            var actual = solution.SecondTry(list, kth, 0);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.LinkedLists.KthLast.KthLast.Data();
    }
}
