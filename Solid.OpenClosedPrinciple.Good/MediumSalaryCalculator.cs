﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.Good;
public class MediumSalaryCalculator : ISalaryCalculate
{
    public decimal Calculate(decimal salary)
    {
        return salary * 4;
    }
}
