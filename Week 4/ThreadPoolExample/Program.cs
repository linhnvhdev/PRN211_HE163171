using System;
using System.Threading;
using ThreadPoolExample;
Console.WriteLine("***** Fun with the .NET Core Runtime Thread Pool *****\n");
Console.WriteLine("Main thread started. ThreadID = {0}",
 Thread.CurrentThread.ManagedThreadId);
Printer p = new Printer();
WaitCallback workItem = new WaitCallback(PrintTheNumbers);
// Queue the method ten times.
for (int i = 0; i < 10; i++)
{
    ThreadPool.QueueUserWorkItem(workItem, p);
}
Console.WriteLine("All tasks queued");
Console.ReadLine();

static void PrintTheNumbers(object state)
{
    Printer task = (Printer)state;
    task.PrintNumbers();
}

namespace ThreadPoolExample
{
    public class Printer
    {
        private object lockObject = new object();

        public void PrintNumbers()
        {
            lock (lockObject)
            {
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Your Numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("{0} ", i);
                    Thread.Sleep(2000);
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
