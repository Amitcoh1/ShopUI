﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public Vendor Owner { get; set; }
        public int Amount { get; set; }

        public string Disply
        {
            get { return string.Format("{0} - ${1}",Title,Price); }
        }
    }
}
