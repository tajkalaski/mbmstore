using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
         public string Title { get; set; }
         public decimal Price { get; set; }
         public string ImgUrl { get; set; }
         public int ProductID { get; set; }
        public string Category { get; set; }

        public Product(int productID, string title, decimal price, string imgUrl)
        {
            ProductID = productID;
            Title = title;
            Price = price;
            ImgUrl = imgUrl;
        }

        public Product()
        {
        
            
        }
    }
}
