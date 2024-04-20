namespace Solid.OpenClosedPrenciple.Bad;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        SalaryCalculator salaryCalculator = new SalaryCalculator();
        Console.WriteLine($"Low Salary\t: {salaryCalculator.Calculate(1000, SalaryType.Low)}");
        Console.WriteLine($"Medium Salary\t: {salaryCalculator.Calculate(1000,SalaryType.Medium)}");
        Console.WriteLine($"High Salary\t: {salaryCalculator.Calculate(1000, SalaryType.High)}");
    }

    
}
