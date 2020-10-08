using System;
using System.Collections.Generic;

namespace PalindromePermutations
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter string to get palindromic permutations: ");
            string text = Console.ReadLine();

            if (PalindromePermutationsSolver.TryGeneratePalindromicPermutations(text, out List<string> palindromes))
            {
                Console.WriteLine("The palindromes produced from your text are: ");
                foreach (var palindrome in palindromes)
                    Console.WriteLine(palindrome);
            }
            else
            {
                Console.WriteLine("No permutations of this text contain palindromes.");
            }

            Console.ReadKey();
        }
    }
}
