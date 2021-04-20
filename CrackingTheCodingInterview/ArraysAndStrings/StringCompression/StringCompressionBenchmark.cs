using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Etlx;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.StringCompression
{
    public class StringCompressionBenchmark : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "aabcccccaaa", "a2b1c5a3" };
            yield return new object[] { "aabccccccccccaaa", "a2b1c10a3" };
            yield return new object[] { "abc", "abc" };
            yield return new object[] { "ab", "ab" };
            yield return new object[] { "a", "a" };
        }

        [Benchmark(Description = "StringBuilder")]
        [ArgumentsSource(nameof(Data))]
        public string FirstTry(string A, string expected)
        {
            if (A.Length < 2)
            {
                return A;
            }

            var sb = new System.Text.StringBuilder(A.Length + 2);

            char current = A[0];
            int count = 0;

            for (int i = 0; i < A.Length && sb.Length < A.Length; i++)
            {
                if (current == A[i])
                {
                    count++;
                }
                else
                {
                    sb.Append(current);
                    sb.Append(count);

                    current = A[i];
                    count = 1;
                }
            }

            sb.Append(current);
            sb.Append(count);

            if (sb.Length > A.Length)
            {
                return A;
            }


            return sb.ToString();
        }

        [Benchmark(Description = "SB Refactored")]
        [ArgumentsSource(nameof(Data))]
        public string SecondTry(string A, string expected)
        {
            if (A.Length < 2)
            {
                return A;
            }

            // +2 to avoid SB resize
            var sb = new System.Text.StringBuilder(A.Length + 2);
            int count = 0;

            for (int i = 0; i < A.Length && sb.Length < A.Length; i++)
            {
                count++;

                if (i + 1 >= A.Length || A[i + 1] != A[i])
                {
                    sb.Append(A[i]);
                    sb.Append(count);

                    count = 0;
                }
            }

            if (sb.Length >= A.Length)
            {
                return A;
            }


            return sb.ToString();
        }

    }
}
