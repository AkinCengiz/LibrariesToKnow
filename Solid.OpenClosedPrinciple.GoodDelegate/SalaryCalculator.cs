using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.GoodDelegate;
public class SalaryCalculator
{
    public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate)
    {
        return calculateDelegate(salary);
    }
}
