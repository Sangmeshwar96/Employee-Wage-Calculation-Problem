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
            Emp emp = new Emp();
            emp.Wage("TCS", 20);
            emp.Wage("Wipro", 30);
        }
    }
}