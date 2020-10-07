using System;
using System.Text.RegularExpressions;

namespace PalindromePermutations.Utilities
{
    public static class StringUtilities
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

        public static bool IsCharacterCountOdd(this string text) => text.Length % 2 == 1;
    }
}
