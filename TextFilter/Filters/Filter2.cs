using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public class Filter2 : IFilter2
    {
        public bool IsFilteredWord(string word)
            => word.Length < 3;
    }
}
