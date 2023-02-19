using EmployeeWageCalculation;
using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation ");
            EmpWageBuilderObject empWageBuilderObject = new EmpWageBuilderObject();
            empWageBuilderObject.AddCompanyEmpWage("DMart", 20, 15, 100);
            empWageBuilderObject.AddCompanyEmpWage("Reliance", 10, 20, 200);
            empWageBuilderObject.ComputeEmpWage();
            empWageBuilderObject.GetTotalWageForAllCompany();
        }
    }
}