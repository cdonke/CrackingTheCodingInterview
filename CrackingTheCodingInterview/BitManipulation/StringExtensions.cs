using System;
namespace CrackingTheCodingInterview.BitManipulation
{
    public static class StringExtensions
    {
        public static int ToBinary (this string S)
        {
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != '0' && S[i] != '1')
                {
                    throw new InvalidCastException("Not a binary notarion");
                }
            }

            return Convert.ToInt32(S, 2);
        }
    }
}
