using PalindromePermutations.Utilities;
using Xunit;

namespace UnitTests.UtilityTests
{
    public class CleanStringTests
    {
        [Fact]
        public void CleanString_WhenStringContainsUpperCaseLetters_ReturnsLowerCaseString()
        {
            // Arrange
            string stringToClean = "A";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasLeadingAndTrailingWhitespace_ReturnsStringWithoutWhitespace()
        {
            // Arrange
            string stringToClean = " a ";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasEmbeddedWhitespace_ReturnsStringWithoutWhitespace()
        {
            // Arrange
            string stringToClean = "a a";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "aa", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasSpecialCharacters_ReturnsStringWithoutSpecialCharacters()
        {
            // Arrange
            string stringToClean = "a#%^*&.";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }
    }
}
