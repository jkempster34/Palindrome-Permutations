using PalindromePermutations;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.PalindromicPermuationsSolverTests
{
    public class TryGenerateOutValueTests
    {
        [Fact]
        public void TryGenerate_WhenStringContainsOneLetter_OutValueIsSameLetter()
        {
            // Arrange
            const string stringToTest = "a";

            // Act
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Single(palindromes);
            Assert.Equal(expected: stringToTest, actual: palindromes[0]);
        }

        [Fact]
        public void TryGenerate_WhenStringOfLengthTwoIsPalindrome_OutValueIsSameString()
        {
            // Arrange
            const string stringToTest = "aa";

            // Act
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Single(palindromes);
            Assert.Equal(expected: stringToTest, actual: palindromes[0]);
        }

        [Fact]
        public void TryGenerate_WhenStringWithOddCharactersIsPalindrome_OutValueContainsAllPalindromicPermuations()
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
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGenerate_WhenStringWithEvenCharactersIsPalindrome_OutValueContainsAllPalindromicPermuations()
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
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGenerate_WhenStringWithOddCharactersContainsPalindromes_OutValueContainsAllPalindromicPermuations()
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
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGenerate_WhenStringWithEvenCharactersContainsPalindromes_OutValueContainsAllPalindromicPermuations()
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
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Equal(expected: expectedPalindromes.OrderBy(p => p), actual: palindromes.OrderBy(p => p));
        }

        [Fact]
        public void TryGenerate_WhenStringCanNotFormPalindrome_OutValueIsNull()
        {
            // Arrange
            const string stringToTest = "ab";

            // Act
            PalindromicPermutationsSolver.TryGenerate(stringToTest, out List<string> palindromes);

            // Assert
            Assert.Null(palindromes);
        }
    }
}
