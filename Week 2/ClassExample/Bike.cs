using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Bike
    {
        private int _wheel;
        private int _item;
        private string _name;
        public int Wheel { get { return _wheel; } set { _wheel = value; } }

        public int Item { get { return _item; } set { _item = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public Bike(int wheel) : this(wheel, 0, "")
        {

        }

        public Bike(int wheel, int item, string Name)
        {
            _wheel = wheel;
            _item = item;
            _name = Name;
        }

        public void test()
        {
            Console.WriteLine("Bike Test was called");
        }
    }
}
