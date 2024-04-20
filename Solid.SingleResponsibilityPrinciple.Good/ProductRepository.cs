﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrinciple.Good;
public class ProductRepository
{
    private static List<Product> ProductList = new List<Product>();

    public ProductRepository()
    {
        ProductList = new List<Product>()
        {
            new Product() { Id = 1, Name = "Kalem 1" },
            new Product() { Id = 2, Name = "Kalem 2" },
            new Product() { Id = 3, Name = "Kalem 3" },
            new Product() { Id = 4, Name = "Kalem 4" },
            new Product() { Id = 5, Name = "Kalem 5" }
        };
    }
    public List<Product> GetProducts => ProductList;

    public void SaveOrUpdate(Product product)
    {
        var hasProduct = ProductList.Any(p => p.Id == product.Id);
        if (!hasProduct)
        {
            ProductList.Add(product);
        }
        else
        {
            var index = ProductList.FindIndex(x => x.Id == product.Id);
            ProductList[index] = product;
        }
    }

    public void Delete(int id)
    {
        var hasProduct = ProductList.FirstOrDefault(x => x.Id == id);
        if (hasProduct == null)
        {
            throw new Exception("Ürün bulunamadı...");
        }

        ProductList.Remove(hasProduct);
    }
}
