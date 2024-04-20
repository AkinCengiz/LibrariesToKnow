using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion;
public class ProductRepositoryOracleServer : IProductRepository
{
    public List<Product> Products { get; set; } = new List<Product>();
    public ProductRepositoryOracleServer()
    {
        Products.AddRange(new List<Product>()
        {
            new Product() { Id = 1, Name = "Oracle 1" }, new Product() { Id = 2, Name = "Oracle 2" },
            new() { Id = 3, Name = "Oracle 3" }
        });
    }
    public List<Product> GetList()
    {
        return Products;
    }
}
