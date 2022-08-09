using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter.Services
{
    public class TextFilter : ITextFilter
    {
        IFilter1 _filter1;
        IFilter2 _filter2;
        IFilter3 _filter3;

        public TextFilter(IFilter1 filter1, IFilter2 filter2, IFilter3 filter3)
        {
            _filter1 = filter1;
            _filter2 = filter2;
            _filter3 = filter3;
        }

        public string GetFilteredText(string originalText)
        {
            if (originalText.Length > 2)
            {
                var splitText = originalText.Split(' ');
                StringBuilder filteredText = new StringBuilder();

                foreach (var word in splitText)
                {
                    if (!_filter1.IsFilteredWord(word)
                        && !_filter2.IsFilteredWord(word)
                        && !_filter3.IsFilteredWord(word))
                    {
                        filteredText.Append(word + ' ');
                    }
                }

                if (filteredText[filteredText.Length-1] == ' ') filteredText.Remove(filteredText.Length - 1, 1);

                return filteredText.ToString();
            }

            return originalText;
        }
    }
}
