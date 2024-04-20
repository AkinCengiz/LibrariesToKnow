using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple;
public class WriteProductRepository :IWriteRepository
{
    public void Create()
    {
        Console.WriteLine("Ürün oluşturuldu...");
    }

    public void Update()
    {
        Console.WriteLine("Ürün güncellendi...");
    }

    public void Delete()
    {
        Console.WriteLine("Ürün silindi...");
    }
}
