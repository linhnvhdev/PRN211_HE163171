using System;
using System.Collections.Generic;

namespace LambdaExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            //---------- Call FindAll() using traditional delegate syntax.
            //Predicate<int> callback = IsEvenNumber;
            //List<int> evenNumbers = list.FindAll(IsEvenNumber);
            //---------- Use Anonymous method
            /*
            List<int> evenNumbers = list.FindAll(
                delegate(int i)
                {
                    return i % 2 == 0; 
                }
            );*/
            //---------- Lambda
            List<int> evenNumbers = list.FindAll(i => i % 2 == 1);
            evenNumbers.Sort((a, b) => b - a);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }
    }
}
