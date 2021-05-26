using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace CrackingTheCodingInterview.BitManipulation.Insertion
{
    public class Insertion: BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "10000000000".ToBinary(), "10011".ToBinary(), 2, 6, "10001001100".ToBinary()};
            yield return new object[] { "11111111111".ToBinary(), "10011".ToBinary(), 2, 6, "11111001111".ToBinary()};
        }

        //[Benchmark]
        //[Arguments(nameof(Data))]
        //public int FirstTry(int N, int M, int i, int j, int expected)
        //{
        //    M <<= i;

        //    var r = N | M;

        //    return r;
        //}

        [Benchmark]
        [Arguments(nameof(Data))]
        public int SecondTry(int N, int M, int i, int j, int expected)
        {
            var mask = (-1 << (j + 1));
            mask |= ((1 << i) - 1);

            // Clear bits
            N &= mask;

            // Shift left M i positions
            M <<= i;

            // Apply M to N
            N |= M;

            return N;
        }

        [Benchmark]
        [Arguments(nameof(Data))]
        public int ThirdTry(int N, int M, int i, int j, int expected)
        {
            int allOnes = ~0;
            int left = allOnes << (j + 1);
            int right = ((1 << i) - 1);

            int mask = left | right;

            // Clear bits
            N &= mask;

            // Shift left M i positions
            M <<= i;

            // Apply M to N
            N |= M;

            return N;
        }
    }
}
