using TextFilterUtilities;

using Xunit;

namespace TextFilter.UnitTests
{
    public class Filter1Tests
    {
        [Theory]
        [InlineData("clean", true)]
        [InlineData("what", true)]
        [InlineData("currently", true)]
        [InlineData("the", false)]
        [InlineData("rather", false)]
        [InlineData("WHAT", true)]
        [InlineData("CLEAN", true)]
        [InlineData("On", true)]
        [InlineData("I", true)]
        public void IsFiltered_ShouldReturnCorrectBoolean(string word, bool expected)
        {
            //Arrange
            Filter1 filter = new Filter1();

            //Action
            var actual = filter.IsFilteredWord(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}