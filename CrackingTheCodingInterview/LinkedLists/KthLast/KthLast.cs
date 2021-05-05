using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LinkedLists.KthLast
{
    public class KthLast : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new LinkedList<int>(new[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }), 1, 1 };
            yield return new object[] { new LinkedList<int>(new[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }), 4, 4 };
            yield return new object[] { new LinkedList<int>(new[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }), 2, 2 };
        }

        public int FirstTry(LinkedList<int> list, int kth, int expected)
        {
            var node = list.First;
            var kthElement = list.Count - kth;
            for (int i = 0; i < kthElement; i++)
            {
                node = node.Next;
            }

            return node.Value;
        }

        // Thinking if a scenario where I don't have the LinkedList Count
        public int SecondTry(LinkedList<int> list, int kth, int expected)
        {
            var node = list.First;
            for (int i = 0; i < kth; i++)
            {
                node = node.Next;
            }

            LinkedListNode<int> kthElement = list.First;

            while(node != null)
            {
                kthElement = kthElement.Next;
                node = node.Next;
            }

            return kthElement.Value;
        }
    }
}