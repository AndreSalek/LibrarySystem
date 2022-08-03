using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentingLibrary
{
    public class SearchParameter
    {
        public string SearchString { get; set; }
        public string SearchData { get; set; }
        public SearchParameter(string searchString, string searchData)
        {
            SearchString = searchString;
            SearchData = searchData;
        }
    }
}
