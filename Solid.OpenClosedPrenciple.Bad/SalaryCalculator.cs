using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrenciple.Bad;
public class SalaryCalculator
{
    public decimal Calculate(decimal salary, SalaryType salaryType)
    {
        decimal newSalary = 0;
        switch (salaryType)
        {
            case SalaryType.Low:
                newSalary = (salary * 2);
                break;
            case SalaryType.Medium:
                newSalary = (salary * 3);
                break;
            case SalaryType.High:
                newSalary = (salary * 5);
                break;
        }
        return newSalary;
    }
}
public enum SalaryType
{
    Low, Medium, High
}
