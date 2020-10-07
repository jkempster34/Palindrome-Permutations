using PalindromePermutations.Utilities;
using System.Collections.Generic;

namespace PalindromePermutations
{
    public class PalindromePermutationsSolver
    {
        public bool IsPalindromicPermutation(string text)
        {
            Dictionary<char, int> letterCount = GroupSameLetters(text);

            int oddLetterCount = 0;

            foreach (KeyValuePair<char, int> entry in letterCount)
            {
                if (entry.Value.IsOdd())
                    oddLetterCount++;
                if (oddLetterCount > 1)
                    return false;
            }

            return (text.IsCharacterCountOdd() && oddLetterCount == 1) ||
                (!text.IsCharacterCountOdd() && oddLetterCount == 0);
        }

        private Dictionary<char, int> GroupSameLetters(string text)
        {
            var letterCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (letterCount.ContainsKey(text[i]))
                {
                    letterCount[text[i]]++;
                }
                else
                {
                    letterCount.Add(key: text[i], value: 1);
                }
            }
            return letterCount;
        }
    }
}
