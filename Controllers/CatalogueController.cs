using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            //Books list
            IEnumerable<MusicCD> musicCDs;
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.MusicCDs = musicCDs;

            //MusicCDs list
            IEnumerable<Book> books;
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;

            //Movies list
            IEnumerable<Movie> movies;
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Moovies = movies;

            ViewBag.Products = Repository.Products;

            return View();
        }
    }
}
