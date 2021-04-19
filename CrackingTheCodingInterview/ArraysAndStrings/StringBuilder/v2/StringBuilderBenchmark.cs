using BenchmarkDotNet.Attributes;
using CrackingTheCodingInterview.DataStructures.StringBuilder.v2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.StringBuilder
{
    [ExcludeFromCodeCoverage]
    public class StringBuilderBenchmark_V2 : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            return StringBuilder.Common.Data();
        }

        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("Append_Constructor")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Append_Constructor(string data)
        {
            var sb = new System.Text.StringBuilder(data);
        }
        [Benchmark(Description = "MyStringBuilder")]
        [BenchmarkCategory("Append_Constructor")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_Append_Constructor(string data)
        {
            var sb = new MyStringBuilder(data);
        }


        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("Append")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Append(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.Append(data);
        }
        [Benchmark(Description = "MyStringBuilder")]
        [BenchmarkCategory("Append")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_Append(string data)
        {
            var sb = new MyStringBuilder();
            sb.Append(data);
        }



        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("AppendLine")]
        [ArgumentsSource(nameof(Data))]
        public void Default_AppendLine(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(data);
        }
        [Benchmark(Description = "MyStringBuilder")]
        [BenchmarkCategory("AppendLine")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_AppendLine(string data)
        {
            var sb = new MyStringBuilder();
            sb.AppendLine(data);
        }




        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("ToString")]
        [ArgumentsSource(nameof(Data))]
        public void Default_ToString(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(data);
            var result = sb.ToString();
        }
        [Benchmark(Description = "MyStringBuilder")]
        [BenchmarkCategory("ToString")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_ToString(string data)
        {
            var sb = new MyStringBuilder();
            sb.AppendLine(data);
            var result = sb.ToString();
        }
    }
}
