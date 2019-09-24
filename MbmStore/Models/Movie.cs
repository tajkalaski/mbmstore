using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        public short Released { get; set; }
        public string Director { get; set; }


        // constructors
        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(int productID, string title, decimal price, string imgUrl, string director) : base (productID, title, price, imgUrl)
        {
            Title = title;
            Price = price;
            ImgUrl = imgUrl;
            Director = director;
        }
    }
}