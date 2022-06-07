using System;
using System.IO;

namespace FIleInfoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"MyFile.txt";
            Console.WriteLine("============== Demo FIleInfo =================");
            if(!File.Exists(fileName)) File.WriteAllText(fileName, "Hello World");
            Console.WriteLine("Read FIle:");
            string content = File.ReadAllText(fileName);
            Console.WriteLine(content);
            Console.WriteLine("File information:");
            FileInfo testFile = new FileInfo(fileName);
            Console.WriteLine($"Name: {testFile.Name}");
            Console.WriteLine($"Creation time: {testFile.CreationTime}");
            Console.WriteLine($"Last Write Time: {testFile.LastWriteTime}");
            Console.WriteLine($"Directory name: {testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
