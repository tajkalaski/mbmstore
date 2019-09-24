using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
            public string Author { get; set; }
            public string Publisher { get; set; }
            public short Published { get; set; }
            public string ISBN { get; set; }

            public Book()
            {
                
            }

            public Book(int productID, string author, string title, decimal price, short published, string iSBN, string imgUrl) : base(productID, title, price,imgUrl)
            {
                Author = author;
                Title = title;
                Price = price;
                Published = published;
                ISBN = iSBN;
            }
    }
}
