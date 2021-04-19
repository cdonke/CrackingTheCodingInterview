using BenchmarkDotNet.Attributes;
using CrackingTheCodingInterview.DataStructures.Hashtable;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CrackingTheCodingInterview.ArraysAndStrings.Hashtable
{

    public class HashtableBenchmark : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            Random random = new Random();
            yield return new object[] { Enumerable.Range(0, 20).OrderBy(q => random.Next()).ToArray(), 5 };
            yield return new object[] { Enumerable.Range(0, 100).OrderBy(q => random.Next()).ToArray(), 100 }; // Default Capacity
            yield return new object[] { Enumerable.Range(0, 1000).OrderBy(q => random.Next()).ToArray(), 100 }; // Default Capacity
            yield return new object[] { Enumerable.Range(0, 1000).OrderBy(q => random.Next()).ToArray(), 1000 };
            yield return new object[] { Enumerable.Range(0, 10000).OrderBy(q => random.Next()).ToArray(), 100 }; // Default Capacity
        }

        [Benchmark(Description = "System.Collections.Hashtable", Baseline = true)]
        [BenchmarkCategory("Add")]
        [ArgumentsSource(nameof(Data))]
        public void DefaultHashtable_Add(int[] items, int capacity)
        {
            var hashtable = new System.Collections.Hashtable(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }
        }

        [Benchmark(Description = "MyHashTable")]
        [BenchmarkCategory("Add")]
        [ArgumentsSource(nameof(Data))]
        public void MyHashtable(int[] items, int capacity)
        {
            var hashtable = new MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }
        }


        [Benchmark(Description = "System.Collections.Hashtable", Baseline = true)]
        [BenchmarkCategory("Get")]
        [ArgumentsSource(nameof(Data))]
        public void DefaultHashtable_Get(int[] items, int capacity)
        {
            var hashtable = new System.Collections.Hashtable(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                var get = hashtable[$"item {i}"];
            }
        }

        [Benchmark(Description = "MyHashtable")]
        [BenchmarkCategory("Get")]
        [ArgumentsSource(nameof(Data))]
        public void MyHashtable_Get(int[] items, int capacity)
        {
            var hashtable = new MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                var get = hashtable[$"item {i}"];
            }
        }

        [Benchmark(Description = "System.Collections.Hashtable", Baseline = true)]
        [BenchmarkCategory("Update")]
        [ArgumentsSource(nameof(Data))]
        public void DefaultHashtable_Update(int[] items, int capacity)
        {
            var hashtable = new System.Collections.Hashtable(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                hashtable[$"item {i}"] = i * i;
            }
        }

        [Benchmark(Description = "MyHashtable")]
        [BenchmarkCategory("Update")]
        [ArgumentsSource(nameof(Data))]
        public void MyHashtable_Update(int[] items, int capacity)
        {
            var hashtable = new MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                hashtable[$"item {i}"] = i * i;
            }
        }


        [Benchmark(Description = "System.Collections.Hashtable", Baseline = true)]
        [BenchmarkCategory("Clear")]
        [ArgumentsSource(nameof(Data))]
        public void DefaultHashtable_Clear(int[] items, int capacity)
        {
            var hashtable = new System.Collections.Hashtable(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            hashtable.Clear();
        }

        [Benchmark(Description = "MyHashtable")]
        [BenchmarkCategory("Clear")]
        [ArgumentsSource(nameof(Data))]
        public void MyHashtable_Clear(int[] items, int capacity)
        {
            var hashtable = new MyHashtable<int>(capacity);
            for (int i = 0; i < items.Length; i++)
            {
                hashtable.Add($"item {items[i]}", items[i]);
            }

            hashtable.Clear();
        }
    }
}
