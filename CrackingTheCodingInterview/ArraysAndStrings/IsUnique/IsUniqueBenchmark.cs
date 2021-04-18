using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.IsUnique
{
    public class IsUniqueBenchmark : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "the quick brown fox jumped over the lazy dog", false };
            yield return new object[] { "the quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dogthe quick brown fox jumped over the lazy dog", false };
            yield return new object[] { "qwertyuioplkjhgfdsazxcvbnm,./'[]\\=-0987654321@#$%^&*()_+", true };
        }

        [Benchmark(Description = "Simple Arrays")]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(string data, bool expected)
        {
            // Default size of ASCII Table
            // If exceeds it, chars have to be repeated
            if (data.Length > 128)
            {
                return false;
            }

            // Create an array to hold each char
            // Once visited, set it to true.
            bool[] chars = new bool[128];

            for (int i = 0; i < data.Length; i++)
            {
                char currentChar = data[i];
                // Allowing whitespaces repetition.
                // This way, it's possible to test sentences instead of words.
                if (currentChar == ' ')
                {
                    continue;
                }


                if (chars[currentChar] == true)
                {
                    return false;
                }
                else
                {
                    chars[currentChar] = true;
                }
            }

            return true;
        }

        /// <summary>
        /// This try violates the exercise proposition of no using additional data structures.
        /// But, for performance comparrison, HashSet is used.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Benchmark(Description = "HashSet")]
        [ArgumentsSource(nameof(Data))]
        public bool SecondTry(string data, bool expected)
        {
            // Default size of ASCII Table
            // If exceeds it, chars have to be repeated
            if (data.Length > 128)
            {
                return false;
            }

            // Create a hashset to hold the added values.
            var hashset = new HashSet<char>(128);
            for (int i = 0; i < data.Length; i++)
            {
                var added = hashset.Add(data[i]);
                // It will fail to add, if there is already the same key.
                if (added == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
