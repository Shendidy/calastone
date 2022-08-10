using System.IO;
using TextFilterUtilities;
using TFUS = TextFilterUtilities.Services;
using Xunit;

namespace TextFilter.Tests.IntegrationTests
{
    public class TextFilter_IntegrationTests
    {
        [Theory]
        [InlineData(@"./IntegrationTests/TestFiles/test1.txt", @"./IntegrationTests//TestFiles/solution1.txt")]
        [InlineData(@"./IntegrationTests/TestFiles/test2.txt", @"./IntegrationTests//TestFiles/solution2.txt")]
        public void GetFilteredText_ShouldReturnCorrectFilteredText(string input, string expectedPath)
        {
            //Arrange
            var testText = File.ReadAllText(input);
            var expected = File.ReadAllText(expectedPath);

            IFilter1 filter1 = new Filter1();
            IFilter2 filter2 = new Filter2();
            IFilter3 filter3 = new Filter3();

            ITextFilter textFilter = new TFUS.TextFilter(filter1, filter2, filter3);

            //Action
            var actual = textFilter.GetFilteredText(testText);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}