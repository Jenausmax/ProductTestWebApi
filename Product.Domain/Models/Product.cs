using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
