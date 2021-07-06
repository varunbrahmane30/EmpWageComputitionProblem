using System;
using WageProblem.FinalSolution;

namespace WageProblem
{
    class Program
    { 
        static void Main(string[] args)
        {
            //    UC2EmpDailyWage.EmpPartTime();
            //    UC3PartTimeEmpWage.EmpDailyWage();
            //    UC4EmpWageUsingSwitch.EmpWageSwitch();
            //    UC5CalWageForMonth.wageMonth();
            //    UC6TotalEmpWageTillCondotion100.calConditionTillHourRiched();
            // UC7UsingClassMethod.computeEmpWage();
            //UC8ComputeForMUltipleCompany.computeEmpWage("DMart", 20, 2, 10);
            //UC8ComputeForMUltipleCompany.computeEmpWage("Reliance", 10, 4, 20);

            //#region UC9 Implementation
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());
            //Console.ReadKey();
            //#endregion

            //#region  UC10 Implemantatiton
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuilder.computeEmpWage();
            //#endregion

            #region UC10
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            #endregion
            Console.ReadKey();
            
        }

    }
}
