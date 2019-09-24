using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }        
        //Read-Only Property
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();
        public decimal TotalPrice
        {
            get
            {
                return CalculatePrice();
            }
        }

        public decimal CalculatePrice()

            {
            decimal TotalPrice = 0;

                foreach (OrderItem item in OrderItems)
                {
                    TotalPrice += item.ItemsPrice;
                }
                return TotalPrice;
            }


        //Constructor
        public Invoice(int invoiceID, DateTime orderDate, Customer customer)
        {
            InvoiceID = invoiceID;
            OrderDate = orderDate;
            Customer = customer;
        }

        // Method
        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
