using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple;
public class ReadProductRepository : IReadRepository
{
    List<Product> products = new List<Product>();
    
    public List<Product> GetProductList()
    {
        return products;
    }

    public Product GetById()
    {
        return products[1];
    }
}
