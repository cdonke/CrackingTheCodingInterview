using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class StringCompressionTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string A, string expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.StringCompression.StringCompressionBenchmark();
            var actual = solution.FirstTry(A, string.Empty);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(string A, string expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.StringCompression.StringCompressionBenchmark();
            var actual = solution.SecondTry(A, string.Empty);

            Assert.AreEqual(expected, actual);
        }


        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.StringCompression.StringCompressionBenchmark.Data();
    }
}
