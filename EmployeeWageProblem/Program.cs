using System;
namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmployeeWage.Check("Wistron", 20, 22, 25);
            EmployeeWage.Check("Scaler", 20, 22, 25);
        }
    }
}