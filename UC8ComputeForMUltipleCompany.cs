﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WageProblem
{
    class UC8ComputeForMUltipleCompany
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;


        public static int computeEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + "Emp Hrs :  " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Emp wage for company : " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
        //static void Main(string[] args)
        //{
          //  computeEmpWage("DMart", 20, 2, 10);
           // computeEmpWage("Reliance", 10, 4, 20);
        //}
    }
}
