using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterUtilities
{
    public class Filter2 : IFilter2
    {
        public bool IsFilteredWord(string word)
            => word.Length < 3;
    }
}
