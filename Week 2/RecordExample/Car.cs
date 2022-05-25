using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordExample
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; init; }
        public Car() { }
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
}
}
