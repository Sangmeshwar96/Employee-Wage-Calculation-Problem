using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    //Already Using class
    public class Emp
    {
        public int fullTime = 1;
        int empHr = 0;
        int empWage = 0;
        public void Wage(string comp, int wagePerHr)
        {
            Random random = new Random();
            int attendCheck = random.Next(0, 2);
            if (attendCheck == fullTime)
            {
                empHr = 8;
                Console.WriteLine($"\nThe Employee is present.");
            }
            else
            {
                empHr = 0;
                Console.WriteLine($"\nThe Employee wage is absent.");
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine($"\nThe Empployee wage is {empWage}");
        }
    }
}