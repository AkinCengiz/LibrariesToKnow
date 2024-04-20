namespace Solid.OpenClosedPrinciple.GoodDelegate;

internal class Program
{
    static void Main(string[] args)
    {
        SalaryCalculator salaryCalculator = new SalaryCalculator();
        Console.WriteLine($"Low Salary\t: {salaryCalculator.Calculate(1000,new LowSalaryCalculate().Calculate)}");
        Console.WriteLine($"Medium Salary\t: {salaryCalculator.Calculate(1000,new MediumSalaryCalculate().Calculate)}");
        Console.WriteLine($"High Salary\t: {salaryCalculator.Calculate(1000,new HighSalaryCalculate().Calculate)}");
        Console.WriteLine($"Custom Salary\t: {salaryCalculator.Calculate(1000, x => { return x * 10;})}");
    }
}
