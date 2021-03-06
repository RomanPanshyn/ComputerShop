﻿using ComputerShop.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsProductOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
