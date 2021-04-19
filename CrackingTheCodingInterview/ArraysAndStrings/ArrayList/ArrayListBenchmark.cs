using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.ArrayList
{
    public class ArrayListBenchmark : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { Enumerable.Range(0, 10).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 100).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 1000).ToArray(), 100 };
            yield return new object[] { Enumerable.Range(0, 10000).ToArray(), 1000 };
        }

        [Benchmark(Description = "System.Collections.ArrayList", Baseline = true)]
        [BenchmarkCategory("Add")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Add(int[] items, int capacity)
        {
            var arrayList = new System.Collections.ArrayList(capacity);
            foreach (var item in items)
                arrayList.Add(item);
        }

        [Benchmark(Description = "MyArrayList")]
        [BenchmarkCategory("Add")]
        [ArgumentsSource(nameof(Data))]
        public void MyArrayList_Add(int[] items, int capacity)
        {
            var arrayList = new DataStructures.ArrayList.MyArrayList<int>(capacity);
            foreach (var item in items)
                arrayList.Add(item);
        }



        [Benchmark(Description = "System.Collections.ArrayList", Baseline = true)]
        [BenchmarkCategory("AddRange")]
        [ArgumentsSource(nameof(Data))]
        public void Default_AddRange(int[] items, int capacity)
        {
            var arrayList = new System.Collections.ArrayList(capacity);
            arrayList.AddRange(items);
        }

        [Benchmark(Description = "MyArrayList")]
        [BenchmarkCategory("AddRange")]
        [ArgumentsSource(nameof(Data))]
        public void MyArrayList_AddRange(int[] items, int capacity)
        {
            var arrayList = new DataStructures.ArrayList.MyArrayList<int>(capacity);
            arrayList.AddRange(items);
        }




        [Benchmark(Description = "System.Collections.ArrayList", Baseline = true)]
        [BenchmarkCategory("Clear")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Clear(int[] items, int capacity)
        {
            var arrayList = new System.Collections.ArrayList(capacity);
            arrayList.AddRange(items);

            arrayList.Clear();
        }

        [Benchmark(Description = "MyArrayList")]
        [BenchmarkCategory("Clear")]
        [ArgumentsSource(nameof(Data))]
        public void MyArrayList_Clear(int[] items, int capacity)
        {
            var arrayList = new DataStructures.ArrayList.MyArrayList<int>(capacity);
            arrayList.AddRange(items);

            arrayList.Clear();
        }
    }
}
