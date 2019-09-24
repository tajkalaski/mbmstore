using System;
using System.Collections.Generic;
using System.Linq;
using MbmStore.Models;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
