using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrinciple.Good;
public class ProductPresenter
{
    public void WriteToConsole(List<Product> products)
    {
        products.ForEach(p =>
        {
            Console.WriteLine($"{p.Id} - {p.Name}");
        });
    }
}
