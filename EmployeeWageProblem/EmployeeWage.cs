using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, IS_PART_TIME = 2;
        Random random = new Random();
        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void EmpWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            else if (empCheck == IS_PART_TIME)
                empHrs = PART_TIME_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage " + dailyEmpWage);
        }
    }
}