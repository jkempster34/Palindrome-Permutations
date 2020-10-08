using PalindromePermutations.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromePermutations
{
    public static class PalindromePermutationsSolver
    {
        public static bool TryGeneratePalindromicPermutations(string text, out List<string> palindromes)
        {
            string cleanInput = text.CleanString();
            bool isCharacterCountOdd = cleanInput.IsCharacterCountOdd();

            Dictionary<char, int> letterCount = GroupSameLetters(cleanInput);

            if (!IsPalindromicPermutation(letterCount, isCharacterCountOdd))
            {
                palindromes = null;
                return false;
            }
            else
            {
                palindromes = GeneratePalindromes(letterCount, isCharacterCountOdd);
                return true;
            }
        }

        private static List<string> GeneratePalindromes(Dictionary<char, int> letterCount, bool isCharacterCountOdd)
        {
            List<string> palindromes = new List<string>();
            List<string> permutations = new List<string>();
            char? oddLetter = null;
            if (isCharacterCountOdd)
            {
                oddLetter = letterCount.Where(letter => letter.Value.IsOdd()).Select(letter => letter.Key).First();
                letterCount[oddLetter.Value]--;
            }

            StringBuilder halfTotalLetters = new StringBuilder();
            foreach (KeyValuePair<char, int> entry in letterCount)
            {
                halfTotalLetters.Append(value: entry.Key, repeatCount: entry.Value / 2);
            }

            GeneratePermutationsRecursive(permutations, halfTotalLetters.ToString(), string.Empty);

            foreach (string permutation in permutations)
            {
                palindromes.Add($"{permutation}{oddLetter}{permutation.ReverseString()}");
            }
            return palindromes;
        }

        private static void GeneratePermutationsRecursive(List<string> permutations, string input, string permutation)
        {
            if (input.Length == 0)
            {
                permutations.Add(permutation);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                string removedCharacter = input.Substring(startIndex: i, length: 1);
                string remainingCharacters = input.Remove(startIndex: i, count: 1);

                GeneratePermutationsRecursive(permutations, remainingCharacters, permutation + removedCharacter);
            }
        }

        private static bool IsPalindromicPermutation(Dictionary<char, int> letterCount, bool isCharacterCountOdd)
        {
            int oddLetterCount = 0;

            foreach (KeyValuePair<char, int> entry in letterCount)
            {
                if (entry.Value.IsOdd())
                    oddLetterCount++;
                if (oddLetterCount > 1)
                    return false;
            }

            return (isCharacterCountOdd && oddLetterCount == 1) ||
                (!isCharacterCountOdd && oddLetterCount == 0);
        }

        private static Dictionary<char, int> GroupSameLetters(string text)
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

