using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class OneWayTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string A, string B, bool expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.OneWay.OneWayBenchmark();
            var actual = solution.FirstTry(A, B, expected);

            Assert.AreEqual(expected, actual);
        }


        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.OneWay.OneWayBenchmark.Data();
    }
}
