using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;

namespace CrackingTheCodingInterview.ArraysAndStrings.StringRotation
{
    public class StringRotationBenchmark : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "waterbottle", "erbottlewat", true };
            yield return new object[] { "waterbottle", "bottlewater", true };
            yield return new object[] { "waterbottle", "bottleuater", false };
            yield return new object[] { "waterbottle", "eebottlewat", false };
            yield return new object[] { "hotdog", "doghot", true};
            yield return new object[] { "gooddog", "doggood", true };
            yield return new object[] { "gooddog", "oggoodd", true };
        }

        /// <summary>
        /// No allocation used, but the stop point would be 2N, which may be dangerous for performance.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(string s1, string s2, bool expected)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            int len = s1.Length;
            int s1char = 0, matches = 0;
            // Max len is twice the size to guarantee that the it wont turn into a eternal loop
            for (int i = 0; i < 2 * len && matches < len; i++)
            {
                if (s1[s1char] == s2[i % len])
                {
                    matches++;
                    s1char++;
                }

            }

            return matches == len;
        }

        /// <summary>
        /// Implementation based on hint #104
        /// It's a simpler and faster code, but requires allocation.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool SecondTry(string s1, string s2, bool expected)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // Since I'm rotating a string, pasting it twice would, in some point, join the full word
            var concated = s2 + s2;

            // Should have implemented it myself?
            return concated.Contains(s1);
        }

    }
}
