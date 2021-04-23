using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;

namespace CrackingTheCodingInterview.ArraysAndStrings.ZeroMatrix
{
    public class ZeroMatrixBenchmark : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 0, 5 },
                    new int[] { 1, 2, 3, 5 },
                },
                 new int[][]
                {
                    new int[] { 1, 2, 0, 5 },
                    new int[] { 1, 2, 0, 5 },
                    new int[] { 0, 0, 0, 0 },
                    new int[] { 1, 2, 0, 5 },
                },
            };

            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 0, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                },
                 new int[][]
                {
                    new int[] { 0, 0, 0, 0 },
                    new int[] { 0, 2, 3, 5 },
                    new int[] { 0, 2, 3, 5 },
                    new int[] { 0, 2, 3, 5 },
                },
            };

            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 1, 2, 3, 0 },
                },
                 new int[][]
                {
                    new int[] { 1, 2, 3, 0 },
                    new int[] { 1, 2, 3, 0 },
                    new int[] { 1, 2, 3, 0 },
                    new int[] { 0, 0, 0, 0 },
                },
            };
        }

        private struct Node
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }



        #region Resources for Benchmark
        private int[][] _a, _originalA;

        [ExcludeFromCodeCoverage]
        public IEnumerable<int[][]> Data2()
        {
            foreach (object[] item in Data())
            {
                yield return item[0] as int[][];
            }
        }
        private void DeepCopy(int[][] src, out int[][] dst)
        {
            var json = JsonConvert.SerializeObject(src);
            dst = JsonConvert.DeserializeObject<int[][]>(json);
        }

        [ParamsSource(nameof(Data2))]
        public int[][] A
        {
            get
            {
                return _a;
            }
            set
            {
                DeepCopy(value, out _originalA);
                DeepCopy(value, out _a);
            }
        }

        [ExcludeFromCodeCoverage]
        [IterationCleanup]
        public void IterationCleanup()
        {
            DeepCopy(_originalA, out _a);
        }
        #endregion



        [Benchmark]
        public int[][] FirstTry()
        {
            var nodesToClear = new Node[A.Length];

            int cols = A.Length;
            int rows = A[0].Length;
            int lastNodeFilled = 0;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (A[col][row] == 0)
                    {
                        nodesToClear[lastNodeFilled++] = new Node { Col = col, Row = row };
                    }
                }
            }

            for (int i = 0; i < lastNodeFilled; i++)
            {
                var node = nodesToClear[i];
                for (int c = 0; c < cols; c++)
                {
                    A[c][node.Row] = 0;
                }
                for (int r = 0; r < rows; r++)
                {
                    A[node.Col][r] = 0;
                }
            }


            return A;
        }
    }
}
