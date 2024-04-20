using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion;
public class ProductRepositorySqlServer : IProductRepository
{
    public static List<Product> Products { get; set; } = new List<Product>();
    public ProductRepositorySqlServer()
    {
        Products.AddRange(new List<Product>()
        {
            new Product() { Id = 1, Name = "SQL 1" }, new Product() { Id = 2, Name = "SQL 2" },
            new() { Id = 3, Name = "SQL 3" }
        });
    }
    public List<Product> GetList()
    {
        return Products;
    }
}
