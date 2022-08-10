using TextFilterUtilities;
using TFUS = TextFilterUtilities.Services;
using Xunit;

namespace TextFilter.UnitTests
{
    public class TextFilterTests
    {
        [Theory]
        [InlineData("The first man and woman", "and woman")]
        [InlineData("My name is Sherif Shendidy", "Shendidy")]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "Lorem ipsum dolor eiusmod magna")]
        public void FilterText_ShouldReturnExpectedText(string text, string expected)
        {
            //Arrange
            IFilter1 filter1 = new Filter1();
            IFilter2 filter2 = new Filter2();
            IFilter3 filter3 = new Filter3();
            TFUS.TextFilter textFilter = new TFUS.TextFilter(filter1, filter2, filter3);

            //Action
            var actual = textFilter.GetFilteredText(text);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}