using bshoestore.Models.HtmlHelpers;
using System.Collections.Generic;

namespace bshoestore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
        public string Heading { get; internal set; }
        public string CurrentGenre { get; set; }
    }
}


