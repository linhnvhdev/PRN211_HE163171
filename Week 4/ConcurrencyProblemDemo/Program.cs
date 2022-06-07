﻿using System;
using System.Threading;

namespace ConcurrencyProblemDemo
{
    public class Printer
    {
        private object threadLock = new object();
        public void PrintNumbers()
        {
            lock (threadLock)
            {
                // Display Thread info.
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);
                // Print out numbers.
                for (int i = 0; i < 10; i++)
                {
                    // Put thread to sleep for a random amount of time.
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");
            Printer p = new Printer();
            // Make 10 threads that are all pointing to the same
            // method on the same object.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
            }
            // Now start each one.
            foreach (Thread t in threads)
            {
                t.Start();
                //Console.WriteLine("I'm Interrupting");
            }
            Console.ReadLine();
        }
    }
}
