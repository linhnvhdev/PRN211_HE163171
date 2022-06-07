using System;
using System.IO;

namespace StreamWriterAndReaderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Stream Writer And Reader Example =================");
            string input = null;
            string fileName = @"MyData.txt";
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine("Hello World");
            writer.WriteLine("Line 2 of information");
            writer.WriteLine("!!!!!!!!!!!");
            for(int i = 1;i <= 10;i++)
            {
                writer.Write(i + " ");
            }
            writer.Write(writer.NewLine);
            writer.Close();
            Console.WriteLine("File was created");
            Console.WriteLine("Now read data: ==========================");
            StreamReader reader = new StreamReader(fileName);
            while((input = reader.ReadLine())!= null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
            Console.ReadLine();
        }
    }
}
