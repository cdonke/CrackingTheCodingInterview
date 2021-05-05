using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests.LinkedLists
{
    [TestClass]
    public class PartitionTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(LinkedList<int> list, int partition, LinkedList<int> expected)
        {
            var solution = new CrackingTheCodingInterview.LinkedLists.Partition.Partition();
            var actual = solution.FirstTry(list, partition, null);

            CollectionAssert.AreEqual(expected, actual);
        }


        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.LinkedLists.Partition.Partition.Data();
        
    }
}
