using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime.ICorDebug;
using Microsoft.Diagnostics.Runtime.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.OneWay
{
    public class OneWayBenchmark : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "pale", "ple", true };
            yield return new object[] { "pale", "paale", true };
            yield return new object[] { "pale", "pales", true };
            yield return new object[] { "pales", "pale", true };
            yield return new object[] { "pale", "bale", true };
            yield return new object[] { "pale", "bake", false };
            yield return new object[] { "pale", "pa", false };
            yield return new object[] { "pale", "paless", false };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(string A, string B, bool expected)
        {
            if (Math.Abs(A.Length - B.Length) > 1)
            {
                return false;
            }

            int changes = 0;
            int p_left = 0,
                p_right = 0;

            string left, right;
            if (A.Length < B.Length)
            {
                left = B;
                right = A;
            }
            else
            {
                left = A;
                right = B;
            }

            for (int i = 0; i < right.Length; i++)
            {
                if (A[p_left] == B[p_right])
                {
                    p_left++;
                    p_right++;
                }
                else
                {
                    if (A[p_left + 1] == B[p_right])
                    {
                        p_left++;
                    }
                    else if (A[p_left] == B[p_right + 1])
                    {
                        p_right++;
                    }
                    else
                    {
                        p_left++;
                        p_right++;
                    }
                    changes++;
                }
            }

            return changes <= 1;
        }
    }
}
