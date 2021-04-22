using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class StringRotationTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string s1, string s2, bool expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.StringRotation.StringRotationBenchmark();
            var actual = solution.FirstTry(s1, s2, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(string s1, string s2, bool expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.StringRotation.StringRotationBenchmark();
            var actual = solution.SecondTry(s1, s2, expected);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.StringRotation.StringRotationBenchmark.Data();
    }
}
