using System;
using Emplyees;

namespace PolyrmorphicSupportExample
{
    class Hexagon
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a hexagon!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            // A better bonus system!
            Manager chucky = new Manager(92,"chucky",100000,9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            SalesPerson fran = new SalesPerson(93, "franz", 100000, 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine("***** As and is keyword example *****\n");
            // as
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = chucky;
            things[3] = fran;

            foreach (object obj in things)
            {
                Employee h = obj as Employee;
                if (h == null)
                {
                    Console.WriteLine("Object is not a Employee");
                }
                else
                {
                    GivePromotion(h);
                }
            }

        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.EmployeeName);
            if (emp is SalesPerson sp)
            {
                Console.WriteLine("{0} made {1} sale(s)!", sp.EmployeeName,
                sp.SalesNumber);
                Console.WriteLine();
            }
            else if (emp is Manager mng)
            {
                Console.WriteLine("{0} had {1} stock options...", mng.EmployeeName,
                mng.StockOption);
                Console.WriteLine();
            }
        }
    }
}
