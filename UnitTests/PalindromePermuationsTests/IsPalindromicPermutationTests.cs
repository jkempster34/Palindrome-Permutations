using PalindromePermutations;
using Xunit;

namespace UnitTests.PalindromePermuationsTests
{
    public class IsPalindromicPermutationTests
    {
        [Fact]
        public void IsPalindromicPermutation_WhenStringContainsOneLetter_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "a";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.True(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringOfLengthTwoContainsIsPalindrome_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "aa";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.True(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringOfLengthTwoIsNotPalindromicPermutation_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "ab";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.False(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringWithOddCharactersIsPalindromicPermutation_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "racecar";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.True(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringWithOddCharactersIsNotPalindromicPermutation_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecarbs";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.False(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringWithEvenCharactersIsPalindromicPermutation_ReturnsTrue()
        {
            // Arrange
            const string stringToTest = "raccar";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.True(isPalindromicPermutation);
        }

        [Fact]
        public void IsPalindromicPermutation_WhenStringWithEvenCharactersIsNotPalindromicPermutation_ReturnsFalse()
        {
            // Arrange
            const string stringToTest = "racecars";
            var solver = new PalindromePermutationsSolver();

            // Act
            bool isPalindromicPermutation = solver.IsPalindromicPermutation(stringToTest);

            // Assert
            Assert.False(isPalindromicPermutation);
        }
    }
}
