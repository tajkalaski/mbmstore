using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        //GET: Movie
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie(1,"Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau");
            Movie theAvengers = new Movie(1, "Gladiator", 120.60m, "gladiator.jpg", "Ryan Coogler");
            Movie deadpool = new Movie(3, "Forrest Gump", 180.50m, "forrest-gump.jpg", "James Gunn");

            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.TheAvengers = theAvengers;
            ViewBag.Deadpool = deadpool;

            return View();
        }
    }
}