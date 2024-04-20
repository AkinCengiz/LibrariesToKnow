namespace Solid.OpenClosedPrinciple.Good;

internal class Program
{
    static void Main(string[] args)
    {
        SalaryCalculator salaryCalculator = new SalaryCalculator();
        Console.WriteLine($"Low Salary\t: {salaryCalculator.Calculate(1000,new LowSalaryCalculator())}");
        Console.WriteLine($"Medium Salary\t: {salaryCalculator.Calculate(1000, new MediumSalaryCalculator())}");
        Console.WriteLine($"High Salary\t: {salaryCalculator.Calculate(1000, new HighSalaryCalculator())}");
    }
}
