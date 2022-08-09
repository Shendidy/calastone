using Xunit;

namespace TextFilter.UnitTests
{
    public class Filter3Tests
    {
        [Theory]
        [InlineData("clean", false)]
        [InlineData("Hotel", true)]
        [InlineData("Tall", true)]
        [InlineData("Cart", true)]
        [InlineData("March", false)]
        [InlineData("it", true)]
        public void IsFiltered_ShouldReturnCorrectBoolean(string word, bool expected)
        {
            //Arrange
            Filter3 filter = new Filter3();

            //Action
            var actual = filter.IsFilteredWord(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
