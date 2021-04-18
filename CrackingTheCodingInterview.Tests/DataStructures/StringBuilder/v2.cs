using Microsoft.Diagnostics.Runtime.ICorDebug;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Tests.DataStructures.StringBuilder
{
    [TestClass]
    public class StringBuilderTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Append_Constructor(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder(data);

            Assert.AreEqual(data.Length, sb.Count);
            Assert.AreEqual(data, sb.ToString());
            Assert.AreEqual(data.Length, sb.ToString().Length);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Append(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder();
            sb.Append(data);

            Assert.AreEqual(data.Length, sb.Count);
            Assert.AreEqual(data, sb.ToString());
            Assert.AreEqual(data.Length, sb.ToString().Length);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void AppendLine(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder();
            sb.AppendLine(data);

            var newLineLength = Environment.NewLine.Length;

            Assert.AreEqual(data.Length + newLineLength, sb.Count);
            Assert.AreEqual(data + Environment.NewLine, sb.ToString());
            Assert.AreEqual(data.Length + newLineLength, sb.ToString().Length);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void AppendLine_Empty(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder();
            sb.Append(data);
            sb.AppendLine();

            var newLineLength = Environment.NewLine.Length;

            Assert.AreEqual(data.Length + newLineLength, sb.Count);
            Assert.AreEqual(data + Environment.NewLine, sb.ToString());
            Assert.AreEqual(data.Length + newLineLength, sb.ToString().Length);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void AppendLine_NonEmpty(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder();
            sb.AppendLine(data);
            sb.AppendLine();

            var newLineLength = Environment.NewLine.Length;

            Assert.AreEqual(data.Length + 2 * newLineLength, sb.Count);
            Assert.AreEqual(data + Environment.NewLine + Environment.NewLine, sb.ToString());
            Assert.AreEqual(data.Length + 2 * newLineLength, sb.ToString().Length);
        }
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void Clear(string data)
        {
            var sb = new CrackingTheCodingInterview.DataStructures.StringBuilder.MyStringBuilder();
            sb.Append(data);
            sb.Clear();

            Assert.AreEqual(0, sb.Count);
            Assert.AreEqual(string.Empty, sb.ToString());
            Assert.AreEqual(0, sb.ToString().Length);
        }


        public static IEnumerable<object[]> Data()
        {
            return CrackingTheCodingInterview.ArraysAndStrings.StringBuilder.StringBuilderBenchmark.Data();
        }
    }
}
