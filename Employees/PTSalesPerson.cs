using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson: SalesPerson
    {
        public PTSalesPerson(string fullname, int age, int empID, float currpay, string ssn, int numberOfSales)
            :base (fullname, age,empID,currpay,ssn,numberOfSales)
        { }
    }
}
