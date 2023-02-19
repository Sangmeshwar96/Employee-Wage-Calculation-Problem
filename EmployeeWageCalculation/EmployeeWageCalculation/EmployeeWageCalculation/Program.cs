using EmployeeWage;
using System;

namespace EmployeeWageCalculation
{
    //Already Using class

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation ");
            Emp emp1 = new Emp();
            emp1.Wage("TCS", 20, 20, 100);
            Emp emp2 = new Emp();
            emp2.Wage("Wipro", 30, 20, 100);
            Console.WriteLine("\nTotal wage for an employee of TCS is "+emp1.totalWage);
            Console.WriteLine($"\nTotal wage for an employee of Wipro is "+emp2.totalWage);
        }
    }
}