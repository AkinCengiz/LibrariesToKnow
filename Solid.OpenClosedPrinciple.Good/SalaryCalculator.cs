using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.Good;
public class SalaryCalculator
{
    public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate)
    {
        return salaryCalculate.Calculate(salary);
    }
}
