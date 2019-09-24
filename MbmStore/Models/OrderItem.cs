using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        private decimal itemsPrice = 0;
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        // read only property for TotalPrice
        public decimal ItemsPrice
        {
            get
            {
                return itemsPrice;
            }

        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

            itemsPrice = Product.Price * quantity;
        }
    }
}
