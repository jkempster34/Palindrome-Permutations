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

            if (PalindromicPermutationsSolver.TryGenerate(text, out List<string> palindromes))
            {
                Console.WriteLine("The palindromes produced from your text are: ");
                foreach (var palindrome in palindromes)
                    Console.WriteLine(palindrome);
            }
            else
            {
                Console.WriteLine("This text cannot form any palindromes.");
            }

            Console.ReadKey();
        }
    }
}
