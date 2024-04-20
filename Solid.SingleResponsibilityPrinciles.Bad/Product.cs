using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrinciples.Bad;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    private static List<Product> _products = new List<Product>();

    public Product()
    {
        _products = new()
        {
            new Product() { Id = 1, Name = "Product-1" },
            new Product() { Id = 2, Name = "Product-2" },
            new Product() { Id = 3, Name = "Product-3" },
            new Product() { Id = 4, Name = "Product-4" },
            new Product() { Id = 5, Name = "Product-5" }
        };
    }

    public void SaveOrUpdate(Product product)
    {
        var hasProduct = _products.Any(p => p.Id == product.Id);
        if (!hasProduct)
        {
            _products.Add(product);
        }
        else
        {
            var index = _products.FindIndex(x => x.Id == product.Id);
            _products[index] = product;
        }
    }

    public void Delete(int id)
    {
        var hasProduct = _products.FirstOrDefault(x => x.Id == id);
        if (hasProduct == null)
        {
            throw new Exception("Ürün bulunamadı...");
        }

        _products.Remove(hasProduct);
    }

    public void WriteToConsole()
    {
        _products.ForEach(x =>
        {
            Console.WriteLine($"{x.Id} - {x.Name}");
        });
    }

    //public List<Product> GetProducts()
    //{
    //    return _products;
    //}

    public List<Product> GetProducts => _products;
}
