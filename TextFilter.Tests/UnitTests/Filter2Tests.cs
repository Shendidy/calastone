using TextFilterUtilities;

using Xunit;

namespace TextFilter.UnitTests
{
    public class Filter2Tests
    {
        [Theory]
        [InlineData("CLEAN", false)]
        [InlineData("On", true)]
        [InlineData("I", true)]
        [InlineData("", true)]
        public void IsFiltered_ShouldReturnCorrectBoolean(string word, bool expected)
        {
            //Arrange
            Filter2 filter = new Filter2();

            //Action
            var actual = filter.IsFilteredWord(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}