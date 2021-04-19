using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.URLify
{
    public class URLilyBenchmark : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "Mr John Smith    ", 13, "Mr%20John%20Smith" };
            yield return new object[] { "Christiano Donke  ", 16, "Christiano%20Donke" };
            yield return new object[] { "Christiano de Souza Donke      ", 25, "Christiano%20de%20Souza%20Donke" };
        }


        [Benchmark(Description = "Using StringBuilder")]
        [ArgumentsSource(nameof(Data))]
        public string FirstTry(string input, int len, string expected)
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < len; i++)
            {
                if (input[i] == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }

        [Benchmark(Description = "Using in-place string")]
        [ArgumentsSource(nameof(Data))]
        public string SecondTry(string input, int len, string expected)
        {
            char[] chars = new char[input.Length];
            int charPos = input.Length - 1;

            for (int i = len - 1; i >= 0; i--)
            {
                if (input[i] != ' ')
                {
                    chars[charPos--] = input[i];
                }
                else
                {
                    chars[charPos--] = '0';
                    chars[charPos--] = '2';
                    chars[charPos--] = '%';
                }
            }

            return new string(chars);
        }
    }
}
