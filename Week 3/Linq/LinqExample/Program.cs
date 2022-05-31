using System;
using System.Collections.Generic;

namespace LinqExample
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
                Price = 34.00
            };

        }
    }
}
