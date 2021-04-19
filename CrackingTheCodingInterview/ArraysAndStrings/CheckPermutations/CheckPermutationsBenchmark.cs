using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using CrackingTheCodingInterview.DataStructures.Hashtable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.CheckPermutations
{
    public class CheckPermutationsBenchmark : BenchmarkBase
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "abc", "bac", true };
            yield return new object[] { "abc", "abcd", false };
            yield return new object[] { "abbcde", "acbbed", true };
            yield return new object[] { "abbde", "abbbed", false };
            yield return new object[] { "abbcde", "abbbed", false };
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean sed posuere magna. Fusce dapibus ipsum dapibus, facilisis lorem nec, sodales nisl. Integer ornare tempor purus, et scelerisque massa vulputate non. Vestibulum vel lectus id lectus blandit vulputate ut et ex. Cras vel arcu eleifend, facilisis nunc varius, malesuada justo. In hac habitasse platea dictumst. Quisque mollis ultricies diam eu molestie. Ut a diam egestas, volutpat sapien nec, sodales dolor. Ut congue condimentum cras amet.", "s tm aabiuanaacjie r estanVellceptieuull bsitll ridl edou. i mgeoucceiosetsisls  tcu u fs.sgaop sssrldreunc vmr.rcisssulntepcsuaaevaiuttdp omisusaiesidcm  aeislouoauCQ o.nlvc nUnaraftut.patindsnroeuc  Un,eap puo ei ntuledntestecape  at e  s adgss tImt vun saetcc aosberetil is u eil tmesrq u.qr.i , , sslLe s ltoiesaesA. sesrs, mudeene doe lnux mttfulireeluaumotdit dc  uudgair,rueuiplcb o a  io  heeemmte ninhmsetcsep.e,tnaaloi.atcarencdi,vo tlmuFa  oi m guma srp peemiaa vspddb inm a nsI l eeia,llt", true };
            yield return new object[] { "Iorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean sed posuere magna. Fusce dapibus ipsum dapibus, facilisis lorem nec, sodales nisl. Integer ornare tempor purus, et scelerisque massa vulputate non. Vestibulum vel lectus id lectus blandit vulputate ut et ex. Cras vel arcu eleifend, facilisis nunc varius, malesuada justo. In hac habitasse platea dictumst. Quisque mollis ultricies diam eu molestie. Ut a diam egestas, volutpat sapien nec, sodales dolor. Ut congue condimentum cras amet.", "s tm aabiuanaacjie r estanVellceptieuull bsitll ridl edou. i mgeoucceiosetsisls  tcu u fs.sgaop sssrldreunc vmr.rcisssulntepcsuaaevaiuttdp omisusaiesidcm  aeislouoauCQ o.nlvc nUnaraftut.patindsnroeuc  Un,eap puo ei ntuledntestecape  at e  s adgss tImt vun saetcc aosberetil is u eil tmesrq u.qr.i , , sslLe s ltoiesaesA. sesrs, mudeene doe lnux mttfulireeluaumotdit dc  uudgair,rueuiplcb o a  io  heeemmte ninhmsetcsep.e,tnaaloi.atcarencdi,vo tlmuFa  oi m guma srp peemiaa vspddb inm a nsI l eeia,llt", false };
        }

        [Benchmark(Description = "int[128]", Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(string A, string B, bool expected)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            // Considering an ascii table and not unicode.
            int[] chars = new int[128];
            for (int i = 0; i < A.Length; i++)
            {
                chars[A[i]]++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                chars[B[i]]--;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != 0)
                    return false;
            }

            return true;
        }

        // Test disabled because it will never pass.
        // The logic has a flaw in it, that will return wrong in some scenarios
        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        [ExcludeFromCodeCoverage]
        public bool SecondTry(string A, string B, bool expected)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            HashSet<char> chars = new HashSet<char>(A.Length / 2);
            for (int i = 0; i < A.Length; i++)
            {
                chars.Add(A[i]);
            }

            for (int i = 0; i < B.Length; i++)
            {
                // This might fail if len are equal, and some repeated letter is changed.
                if (chars.Add(B[i]))
                {
                    return false;
                }
            }

            return true;
        }

        [Benchmark(Description = "Hashtable")]
        [ArgumentsSource(nameof(Data))]
        public bool ThirdTry(string A, string B, bool expected)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            var chars = new System.Collections.Hashtable();
            for (int i = 0; i < A.Length; i++)
            {
                if (chars.ContainsKey(A[i]))
                {
                    chars[A[i]] = ((int)chars[A[i]]) + 1;
                }
                else
                {
                    chars.Add(A[i], 1);
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (chars.ContainsKey(B[i]))
                {
                    chars[B[i]] = ((int)chars[B[i]]) - 1;
                }
                else
                {
                    return false;
                }
            }

            object zero = (object)0;
            foreach (var key in chars.Keys)
            {
                if (!chars[key].Equals(zero))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// This solution assumes perhaps not the most efficient code, but it's clean.
        /// Time Complexity increases because of Sorting. Allocation as well.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Benchmark(Description = "String to char[] to string")]
        [ArgumentsSource(nameof(Data))]
        public bool FourthTry(string A, string B, bool expected)
        {
            if (A.Length != B.Length)
            {
                return false;
            }


            char[]
                orderedA = A.ToCharArray(),
                orderedB = B.ToCharArray();

            Array.Sort(orderedA);
            Array.Sort(orderedB);

            return new string(orderedA).Equals(new string(orderedB));
        }

        /// <summary>
        /// This solution assumes perhaps not the most efficient code, but it's clean.
        /// Time Complexity increases because of Sorting. Allocation as well.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Benchmark(Description = "String to char[]")]
        [ArgumentsSource(nameof(Data))]
        public bool FifthTry(string A, string B, bool expected)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            char[]
                orderedA = A.ToCharArray(),
                orderedB = B.ToCharArray();

            Array.Sort(orderedA);
            Array.Sort(orderedB);

            for (int i = 0; i < A.Length; i++)
            {
                if (orderedA[i] != orderedB[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
