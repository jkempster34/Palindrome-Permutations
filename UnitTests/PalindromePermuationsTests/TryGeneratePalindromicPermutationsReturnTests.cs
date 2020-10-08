using PalindromePermutations;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.PalindromePermuationsTests
{
    public class TryGeneratePalindromicPermutationsReturnTests
    {
        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringContainsOneLetter_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "a";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringOfLengthTwoIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "aa";

            // Act 
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringOfLengthTwoIsNotPalindrome_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "ab";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithOddCharactersIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "racecar";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithOddCharactersIsNotPalindromicPermutation_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecarbs";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithEvenCharactersIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "raccar";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithEvenCharactersIsNotPalindromicPermutation_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecars";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithOddCharactersIsPalindromicPermutation_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "rraacce";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGeneratePalindromicPermutations_WhenStringWithEvenCharactersIsPalindromicPermutation_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "rraacc";

            // Act
            bool containsPalindromes = PalindromePermutationsSolver.TryGeneratePalindromicPermutations(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }
    }
}
