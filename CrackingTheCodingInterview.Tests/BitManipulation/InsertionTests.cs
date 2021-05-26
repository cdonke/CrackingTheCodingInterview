using System;
using System.Collections.Generic;
using CrackingTheCodingInterview.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests.BitManipulation
{
    [TestClass]
    public class InsertionTests
    {
        //[TestMethod]
        //[DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        //public void FirstTry(int N, int M, int i, int j, int expected)
        //{
        //    var solution = new CrackingTheCodingInterview.BitManipulation.Insertion.Insertion();
        //    var actual = solution.FirstTry(N, M, i, j, 0);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int N, int M, int i, int j, int expected)
        {
            var solution = new CrackingTheCodingInterview.BitManipulation.Insertion.Insertion();
            var actual = solution.SecondTry(N, M, i, j, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int N, int M, int i, int j, int expected)
        {
            var solution = new CrackingTheCodingInterview.BitManipulation.Insertion.Insertion();
            var actual = solution.ThirdTry(N, M, i, j, 0);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
            => CrackingTheCodingInterview.BitManipulation.Insertion.Insertion.Data();
    }
}
