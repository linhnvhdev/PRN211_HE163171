using System;
using System.Numerics;
using System.Linq;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            swap(ref a, ref b);
            Console.WriteLine($"{a} and {b}");
            Console.WriteLine("Sum of multiple var is {0}",getSum(a,b,1,2,3,4));
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(getSum(b: 5.5, a: array));
            
        }

        static void swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static int getSum(double b, params int[] a)
        {
            int sum = 0;
            foreach(int i in a)
            {
                sum += i;
            }
            return sum;
        }
    }
}
