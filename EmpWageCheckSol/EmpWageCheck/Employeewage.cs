﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCheck
{
    internal class Employeewage
    {
        public static void Dailywage()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                 empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is " + empWage);
        }
    }
}
