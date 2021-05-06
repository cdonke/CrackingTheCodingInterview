using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.LinkedLists
{
    [TestClass]
    public class RemoveDupsTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(LinkedList<int> A, int[] expected)
        {
            var solution = new CrackingTheCodingInterview.LinkedLists.RemoveDups.RemoveDups();
            var actual = solution.FirstTry(A, null);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(LinkedList<int> A, int[] expected)
        {
            var solution = new CrackingTheCodingInterview.LinkedLists.RemoveDups.RemoveDups();
            var actual = solution.SecondTry(A, null);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
         => CrackingTheCodingInterview.LinkedLists.RemoveDups.RemoveDups.Data();
    }
}
