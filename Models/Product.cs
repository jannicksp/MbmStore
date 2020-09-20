using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MbmStore.Models
{
    public class Product
    {
        // fields
        private decimal price;
        private string imageFileName;

        // properties
        public string Title { get; set; }

        public string ImageFileName
        {
            set { imageFileName = value; }
            get { return imageFileName; }
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        // constructors
        public Product() { }

        public Product(string title, decimal price)
        {
            Title = title;
            this.price = price;
        }

        public Product(string title, decimal price, string imageFileName)
        {
            Title = title;
            Price = price;
            ImageFileName = imageFileName;
        }
    }

 

}


