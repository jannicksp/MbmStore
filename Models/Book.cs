using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product {
        //Properties
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published {get;set;}
        public string ISBN { get; set; }

        // Constructors
        public Book() { }

        public Book(string title, string author, decimal price,  short published, string imageFileName) : base(title, price, imageFileName) {
            Author = author;
            Published = published;
            ImageFileName = imageFileName;
        }
    }
}
