using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class FaceProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name="ASUS",Price=25000},
            new Product {Name="Acer",Price=30000},
            new Product {Name="MSI",Price=55000}
        }.AsQueryable<Product>();
    }
}
