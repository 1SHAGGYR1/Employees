﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson: Employee
    {
        public SalesPerson()
        { }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numOfSales)
            :base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numOfSales;
        }
        public int SalesNumber { get; set; }
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 0 && SalesNumber <= 100)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of sales: {0}", SalesNumber);
        }
    }
}
