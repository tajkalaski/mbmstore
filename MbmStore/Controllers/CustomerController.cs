using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> myCustomer = new List<Customer>();

        //GET: Customer
        public IActionResult Index()
        {

            // create a new Customer object
            Customer cust1  = new Customer("Marina", "Doholici", "Grofthojparken", "8260", "Viby J", Convert.ToDateTime("1996.08.20"));
            Customer cust2 = new Customer("Menalas", "Smith", "Neptunvej", "8270", "Hojbjerg", Convert.ToDateTime("1996.02.05"));
            Customer cust3 = new Customer("Lisa", "Simpson", "Banegårdspladsen", "8000", "Aarhus C", Convert.ToDateTime("1996.05.10"));


            // assign a viewbag property to the new Customer object
            ViewBag.Cust1 = cust1;
            ViewBag.Cust2 = cust2;
            ViewBag.Cust3 = cust3;

            cust1.addPhone("44561465");
            cust1.addPhone("44541465");
            cust2.addPhone("49561465");
            cust3.addPhone("44561785");

            // Use the method Add to add new elements to the list
            myCustomer.Add(cust1);
            myCustomer.Add(cust2);
            myCustomer.Add(cust3);

            ViewBag.Customers = myCustomer;

            return View();
        }
    }
}

