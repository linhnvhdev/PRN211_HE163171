using System;
using System.Collections;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n***Error***");
                Console.WriteLine("Method: {0}",e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stacktrace: {0}", e.StackTrace);
                Console.WriteLine("Help link is: {0}",e.HelpLink);
                Console.WriteLine("\n-> Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
