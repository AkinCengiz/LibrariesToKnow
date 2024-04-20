
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion;
public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository repository)
    {
        _productRepository = repository;
    }

    public List<Product> GetAll()
    {
        return _productRepository.GetList();
    }
}
