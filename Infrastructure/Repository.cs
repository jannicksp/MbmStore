using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        // List of products and invoices
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        // constructor
        static Repository() 
        {
            //list of Movies
            Products.Add(new Movie("Jungle Book", 160.50m, "junglebook.jpg", "A Man"));
            Products.Add(new Movie("Inception", 120.50m, "", "someOne"));
            Products.Add(new Movie("Shutter Island", 160.50m, "", "anotherOne"));
            Products.Add(new Movie("Star Wars", 100.50m, "", "Lucas"));

            // List of Books
            Products.Add(new Book("Steve Turner", "Hard Day's Write", 150.00M, 2005, "junglebook.jpg"));
            Products.Add(new Book("How to lie", "A company", 110.00M, 2011, ""));
            Products.Add(new Book("Zlatans biography", "Zlatan", 150.00M, 2019, ""));
            Products.Add(new Book("Ronaldos biography", "Cristioano ", 250.00M, 2021, ""));


            //List of Music
            MusicCD m1 = new MusicCD("Stevie Wonder", "Album1", 12.95M, 1975, "");
            m1.AddTrack(new Track("Song", new TimeSpan(0, 3, 15)));
            m1.AddTrack(new Track("Song2", new TimeSpan(0, 2, 45)));
            Products.Add(m1);

            Products.Add(new MusicCD("", "", 12.95M, 1975, ""));
            Products.Add(new MusicCD("", "", 12.95M, 1975, ""));
            Products.Add(new MusicCD("", "", 12.95M, 1975, ""));

        }
    }
}
