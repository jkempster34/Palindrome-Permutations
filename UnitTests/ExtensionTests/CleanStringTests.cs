using PalindromePermutations.Extensions;
using Xunit;

namespace UnitTests.ExtensionTests
{
    public class CleanStringTests
    {
        [Fact]
        public void CleanString_WhenStringContainsUpperCaseLetters_ReturnsLowerCaseString()
        {
            // Arrange
            const string stringToClean = "A";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasLeadingAndTrailingWhitespace_ReturnsStringWithoutWhitespace()
        {
            // Arrange
            const string stringToClean = " a ";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasEmbeddedWhitespace_ReturnsStringWithoutWhitespace()
        {
            // Arrange
            const string stringToClean = "a a";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "aa", actual: cleanedString);
        }

        [Fact]
        public void CleanString_WhenStringHasSpecialCharacters_ReturnsStringWithoutSpecialCharacters()
        {
            // Arrange
            const string stringToClean = "a#%^*&.";

            // Act
            string cleanedString = stringToClean.CleanString();

            // Assert
            Assert.Equal(expected: "a", actual: cleanedString);
        }
    }
}
