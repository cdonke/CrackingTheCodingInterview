using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.ArraysAndStrings
{
    [TestClass]
    public class ZeroMatrixTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[][] A, int[][] expected)
        {
            var solution = new CrackingTheCodingInterview.ArraysAndStrings.ZeroMatrix.ZeroMatrixBenchmark();
            solution.A = A;
            var actual = solution.FirstTry();

            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }


        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.ArraysAndStrings.ZeroMatrix.ZeroMatrixBenchmark.Data();
    }
}
