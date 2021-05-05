using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LinkedLists.Partition
{
    public class Partition:BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {
                new LinkedList<int>(new[] { 3, 5, 8, 5, 10, 2, 1 }),
                5,
                new LinkedList<int>(new[] { 3, 2, 1, 5, 8, 5, 10 })
            };
            
        }

        // On default .NET LinkedList implementation, the Node is read-only
        public LinkedList<int> FirstTry(LinkedList<int> list, int partition, LinkedList<int> result)
        {
            LinkedList<int> left = new LinkedList<int>();
            LinkedList<int> right = new LinkedList<int>();

            var currentNode = list.First;
            do
            {
                if (currentNode.Value < partition)
                {
                    left.AddLast(currentNode.Value);
                }
                else
                {
                    right.AddLast(currentNode.Value);
                }

                currentNode = currentNode.Next;
            }
            while (currentNode != null);

            currentNode = right.First;
            while(currentNode != null)
            {
                left.AddLast(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return left;
        }

        //public LinkedList<int> SecondTry(LinkedList<int> list, int partition, LinkedList<int> result)
        //{
           
        //}

    }
}
