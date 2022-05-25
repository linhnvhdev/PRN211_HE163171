using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyees
{
    internal partial class Employee
    {
        private int _empId;
        private string _empName;
        private double _curPay;
        private string _empGmail;

        public Employee()
        {

        }

        public Employee(int empId, string empName, double curPay)
        {
            EmployeeId = empId;
            EmployeeName = empName;
            EmployeeCurPay = curPay;
        }

        public int EmployeeId
        {
            get => _empId;
            set => _empId = value;
        }

        public double EmployeeCurPay
        {
            get { return _curPay; }
            set { _curPay = value; }
        }

        public string EmployeeName
        {
            get { return _empName; }
            set
            {
                if (value.Length < 5)
                {
                    Console.WriteLine("name must have more than 5 char");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public string EmployeeGmail
        {
            get;
            set;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", EmployeeName);
            Console.WriteLine("Id: {0}", EmployeeId);
            Console.WriteLine("Pay: {0}", EmployeeCurPay);
            Console.WriteLine("Gmail: {0}", EmployeeGmail);
        }
    }

    class SalesPerson : Employee
    {
        private double _salesNumber;

        public SalesPerson(int empId, string empName, double curPay, double salesNumber): base(empId,empName,curPay)
        {
           SalesNumber = salesNumber;
        }

        public double SalesNumber
        {
            get => _salesNumber;
            set => _salesNumber = value;
        }

        public override void GiveBonus(double amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
    }

    class Manager : Employee
    {
        private double _stockOption;

        public Manager()
        {

        }

        public Manager(int empId, string empName, double curPay, double stockOption) : base(empId, empName, curPay)
        {
            StockOption = stockOption;
        }

        public double StockOption
        {
            get => _stockOption;
            set => _stockOption = value;
        }

        public override void GiveBonus(double amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOption += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOption);
        }
    }
}
