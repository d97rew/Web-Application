using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository() 
        {
            var initialValue = new[]
            {
                new Product{Name = "Cap", Price=256M },
                new Product{Name = "Wet", Price =233M }
            };
            foreach (var p in initialValue)
            {
                AddProduct(p);
            }
        }

        private void AddProduct(Product p)
        {
            products.Add(p.Name, p);
        }

        public IEnumerable<Product> Products => Product.Values;
    }
    
}
