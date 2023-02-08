using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Emp
    {
        public void Wage()
        {
            int fullTime = 1;
            int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHR = 20;
            int totalWorkingdays = 20;
            int totalWorkingHR = 100;
            int totalEmpHr = 0;
            int totalDay = 0;
            do
            {

                Random random = new Random();
                int attendCheck = random.Next(0, 3);
                if (attendCheck == fullTime)
                {
                    empHr = 8;
                    Console.WriteLine($"\nFull time employee.");
                }
                else if (attendCheck == partTime)
                {
                    empHr = 4;
                    Console.WriteLine("\nPart time employee.");
                }
                else
                {
                    empHr = 0;
                    Console.WriteLine("\nThe employee is absent.");
                }
                totalEmpHr = totalEmpHr + empHr;
                empWage = empHr * wagePerHR;
                Console.WriteLine($"\nEmployee wage is {empWage}.");
                totalDay++;
            } while (totalEmpHr <= totalWorkingHR && totalDay < totalWorkingdays);
            Console.WriteLine($"\nThe total working days per month is {totalWorkingdays} and total working hours is {totalEmpHr}.");
            empWage = totalEmpHr * wagePerHR;
            Console.WriteLine($"\nEmployee wage is {empWage}.");
        }
    }
}