using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public static IEnumerable<Product> Values { get; internal set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
