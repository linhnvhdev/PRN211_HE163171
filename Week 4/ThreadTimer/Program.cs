using System;
using System.Threading;






namespace ThreadTimer
{

    internal class Program
    {
        static int n = 0;
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}",
            DateTime.Now.ToLongTimeString());
        }
        static void Main()
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            Console.ReadLine();

            TimerCallback timeCB = new TimerCallback(PrintTime);
            Timer t = new Timer(
             timeCB, // The TimerCallback delegate object.
             null, // Any info to pass into the called method (null for no info).
             0, // Amount of time to wait before starting (in milliseconds).
             1000); // Interval of time between calls (in milliseconds).
            Console.WriteLine("Hit Enter key to terminate...");
            Console.ReadLine();
        }
    }
}
