using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        protected BenifitPackage empBenifits = new BenifitPackage();
        public Employee()
        {

        }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }
        public Employee(string name, int id, int age, float pay)
            : this(name, age, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Age = age;
            ID = id;
            Name = name;
            Pay = pay;
            SocialSecurityNumber = ssn;
        }
        public double GetBenifitCost()
        {
            return empBenifits.ComputePayDeducaton();
        }
        public BenifitPackage Benefits
        {
            get { return empBenifits; }
            set { empBenifits = value; }
        }
            
        public string SocialSecurityNumber
        {
            get;
        }
        public string Name
        {
            get { return empName; }
            set {
                if (value.Length > 15)
                    Console.WriteLine("Error. Name is too long.");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void Birthday()
        {
            empAge++;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Age: {0}", empAge);
        }
    }
}
