using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterUtilities
{
    public class Filter3 : IFilter3
    {
        public bool IsFilteredWord(string word)
            => word.ToLower().Contains('t');
    }
}