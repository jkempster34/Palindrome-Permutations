using PalindromePermutations;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.PalindromicPermuationsSolverTests
{
    public class TryGenerateReturnValueTests
    {
        [Fact]
        public void TryGenerate_WhenStringContainsOneLetter_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "a";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringOfLengthTwoIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "aa";

            // Act 
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringOfLengthTwoIsNotPalindrome_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "ab";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithOddCharactersIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "racecar";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithOddCharactersIsCanNotFormPalindrome_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecarbs";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithEvenCharactersIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "raccar";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithEvenCharactersCanNotFormPalindrome_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecars";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.False(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithOddCharactersCanFormPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "rraacce";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }

        [Fact]
        public void TryGenerate_WhenStringWithEvenCharactersCanFormPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "rraacc";

            // Act
            bool containsPalindromes = PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.True(containsPalindromes);
        }
    }
}
