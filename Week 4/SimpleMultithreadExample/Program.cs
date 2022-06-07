using System;
using System.Threading;
using SimpleMultithreadExample;

Console.WriteLine("***** The Amazing Thread App *****\n");
Console.Write("Do you want [1] or [2] threads? ");
string threadCount = Console.ReadLine();
Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";
Console.WriteLine("-> {0} is executing main()",Thread.CurrentThread.Name);
Printer p = new Printer();

switch (threadCount)
{
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumber));
        // Make thread background will make program can stop anytime they want
        //backgroundThread.IsBackground = true;
        backgroundThread.Name = "Secondary";
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumber();
        break;
    default:
        Console.WriteLine("idk what you want... you get 1 thread.");
        goto case "1";
}

Console.WriteLine("This is on the main thread, and we are finished.");
Thread.Sleep(1000);
Console.WriteLine("Or are we...");
Thread.Sleep(1000);
Console.WriteLine("Now we are");
Console.ReadLine();

namespace SimpleMultithreadExample
{
    public class Printer
    {
        public void PrintNumber()
        {
            Console.WriteLine("-> {0} is executing PrintNumbers()",Thread.CurrentThread.Name);
            Console.WriteLine("Your Numbers: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0} ",i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
