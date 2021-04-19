using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class URLilyTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string input, int length, string expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.URLify.URLilyBenchmark();
            var actual = solution.FirstTry(input, length, null);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(string input, int length, string expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.URLify.URLilyBenchmark();
            var actual = solution.SecondTry(input, length, null);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.URLify.URLilyBenchmark.Data();
    }
}
