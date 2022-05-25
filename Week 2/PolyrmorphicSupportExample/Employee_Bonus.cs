using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyees
{
    partial class Employee
    {
        public virtual void GiveBonus(double amount) => _curPay += amount;
    }
}
