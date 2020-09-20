﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        //Properties
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; }

        //Constructor
        public OrderItem(Product product, int quantity)
        {
            Quantity = Quantity;
            Product = product;
        }
    }
}
