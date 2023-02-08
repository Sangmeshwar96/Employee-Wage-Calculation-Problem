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
            int empHr = 0;
            int wagePerHr = 20;
            int empWage = 0;

            Random random = new Random();
            int attendCheck = random.Next(0, 2);
            if (attendCheck == fullTime)
            {
                empHr = 8;
                Console.WriteLine($"\nThe Employee is present.\n");
            }
            else
            {
                empHr = 0;
                Console.WriteLine($"\nThe Employee is absent.\n");
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine($"\nThe Empployee wage is {empWage}");
        }
    }
}