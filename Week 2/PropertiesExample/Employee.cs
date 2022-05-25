using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    internal class Employee
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

        public int EmployeeId{ 
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

        public void display()
        {
            Console.WriteLine($"id: {EmployeeId}\n curpay: {EmployeeCurPay}\n name: {EmployeeName}");
        }
    }
}
