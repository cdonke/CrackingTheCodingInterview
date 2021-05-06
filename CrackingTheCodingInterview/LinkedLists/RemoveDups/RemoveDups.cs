using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview.LinkedLists.RemoveDups
{
    public class RemoveDups : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new LinkedList<int>(new[] { 3, 4, 4, 1 }), new[] { 3, 4, 1 } };
            yield return new object[] { new LinkedList<int>(new[] { 8, 4, 2, 6, 8, 5, 7, 9, 4, 1, 6, 8, 3, 2, 6, 9, 5, 4, 4 }), new[] { 8, 4, 2, 6, 5, 7, 9, 1, 3 } };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public LinkedList<int> FirstTry(LinkedList<int> A, int[] expected)
        {
            var hashset = new HashSet<int>();
            var node = A.First;
            while (node != null)
            {
                if (!hashset.Add(node.Value))
                {
                    var next = node.Next;
                    A.Remove(node);
                    node = next;
                }
                else
                {
                    node = node.Next;
                }
            }

            return A;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public LinkedList<int> SecondTry(LinkedList<int> A, int[] expected)
        {
            var runner = A.First;
            var fast = runner.Next;
            while (runner != null)
            {
                while (fast != null)
                {
                    if (runner.Value == fast.Value)
                    {
                        var next = fast.Next;
                        A.Remove(fast);
                        fast = next;
                    }
                    else
                    {
                        fast = fast.Next;
                    }
                }

                runner = runner.Next;
                fast = runner?.Next;
            }

            return A;
        }
    }
}
