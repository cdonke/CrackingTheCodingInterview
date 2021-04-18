using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class IsUniqueTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string data, bool expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.IsUnique.IsUniqueBenchmark();
            var actual = solution.FirstTry(data, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(string data, bool expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.IsUnique.IsUniqueBenchmark();
            var actual = solution.SecondTry(data, expected);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.IsUnique.IsUniqueBenchmark.Data();
    }
}
