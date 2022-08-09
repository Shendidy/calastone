using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public class Filter3 : IFilter3
    {
        public bool IsFilteredWord(string word)
            => word.ToLower().Contains('t');
    }
}