using System;

namespace DelegateExample
{

    public class SimpleMath
    {
        public int Add(int x,int y) { return x + y; }
        public static int Sub(int x,int y) { return x - y; }
    }

    

    internal class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member in the
            // delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");
            BinaryOp b = new BinaryOp(SimpleMath.Sub);
            DisplayDelegateInfo(b);
            SimpleMath m = new SimpleMath();
            b = new BinaryOp(m.Add);
            DisplayDelegateInfo(b);
            int x = 10;
            int y = 10;
            Console.WriteLine("x + y is {0}", b(x, y));
        }
    }


}
