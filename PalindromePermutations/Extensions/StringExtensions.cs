using System;
using System.Text.RegularExpressions;

namespace PalindromePermutations.Extensions
{
    public static class StringExtensions
    {
        public static string CleanString(this string stringToClean)
        {
            stringToClean = stringToClean.ToLower();

            try
            {
                return Regex.Replace(stringToClean, @"[^\w]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return string.Empty;
            }
        }

        public static string ReverseString(this string stringToReverse)
        {
            char[] characters = stringToReverse.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }

        public static bool IsCharacterCountOdd(this string text) => text.Length % 2 == 1;
    }
}
