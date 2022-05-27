using System;
using PublicDelegateProblem;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);
            // Register event handlers.
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;
            c1.AboutToBlow += AboutToBlowVer2;
            Car.CarEngineHandler d = CarExploded;
            c1.Exploded += d;
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            // Remove CarExploded method
            // from invocation list.
            c1.Exploded -= d;
            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();

        }

        private static void AboutToBlowVer2(string msgForCaller)
        {
            throw new NotImplementedException();
        }

        static void CarAboutToBlow(string msg)
        {
            Console.WriteLine(msg);
        }
        static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine("=> Critical Message from Car: {0}", msg);
        }
        static void CarExploded(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
