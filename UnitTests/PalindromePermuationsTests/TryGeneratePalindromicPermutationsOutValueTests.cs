using PalindromePermutations;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.PalindromePermuationsTests
{
    public class TryGeneratePalindromicPermutationsOutValueTests
    {
        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringContainsOneLetter_OutValueIsSameLetter()
        {
            // Arrange
            const string stringToTest = "a";

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Single(palindromes);
            Assert.Equal(expected: stringToTest, actual: palindromes[0]);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringOfLengthTwoIsPalindrome_OutValueIsSameString()
        {
            // Arrange
            const string stringToTest = "aa";

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Single(palindromes);
          
            Assert.Equal(expected: stringToTest, actual: palindromes[0]);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithOddCharactersIsPalindrome_OutValueContainsAllPalindromicPermuations()
        {
            // Arrange
            const string stringToTest = "racecar";
            var expectedPalindromes = new List<string>()
            {
                "racecar",
                "rcaeacr",
                "arcecra",
                "acrerca",
                "craearc",
                "carerac",
            };

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithEvenCharactersIsPalindrome_OutValueContainsAllPalindromicPermuations()
        {
            // Arrange
            const string stringToTest = "raccar";
            var expectedPalindromes = new List<string>()
            {
                "raccar",
                "rcaacr",
                "arccra",
                "acrrca",
                "craarc",
                "carrac",
            };

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithOddCharactersContainsPalindromes_OutValueContainsAllPalindromicPermuations()
        {
            // Arrange
            const string stringToTest = "rraacce";
            var expectedPalindromes = new List<string>()
            {
                "racecar",
                "rcaeacr",
                "arcecra",
                "acrerca",
                "craearc",
                "carerac",
            };

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithEvenCharactersContainsPalindromes_OutValueContainsAllPalindromicPermuations()
        {
            // Arrange
            const string stringToTest = "rraacc";
            var expectedPalindromes = new List<string>()
            {
                "raccar",
                "rcaacr",
                "arccra",
                "acrrca",
                "craarc",
                "carrac",
            };

            // Act
            PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }
    }
}
