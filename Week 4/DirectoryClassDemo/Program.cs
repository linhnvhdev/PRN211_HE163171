using System;
using System.IO;

namespace DirectoryClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get current directory
            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*");
                foreach(var currentFile in txtFiles)
                {
                    Console.WriteLine(currentFile);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
                
        }
    }
}
