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
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            // var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "SomeOne");
            // var Inception = new Movie("Inception ", 190.30m, "", "Who knows");
            // var ShutterIsland = new Movie("Shutter Island", 110.50m, "", "Decaprio");

            // assign a ViewBag property to the new Movie object
            // ViewBag.JungleBook = jungleBook;
            // ViewBag.Inception = Inception;
            // ViewBag.ShutterIsland = ShutterIsland;

            // return the default view
            return View();
        }
    }
}