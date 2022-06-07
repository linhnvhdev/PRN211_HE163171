using System;
using System.IO;

namespace FIleClassDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyData.txt";
            // This text is added once to the file
            if (!File.Exists(path))
            {
                string createText = "Hello And Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
