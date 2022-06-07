using System;
using System.IO;
using System.Text;

namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Demo FileStream Class ===========");
            // Obtain a FileStream object
            using FileStream fStream = File.Open("MyFile.dat", FileMode.Create);
            // Encode a string as an array of bytes
            string msg = "ABCDEFGHIKLMN";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            // Write byte[] to file;
            fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            //Reset internal position of stream;
            fStream.Position = 0;
            // Read the types from file and display to console
            Console.WriteLine("Print message as an array of bytes: \n");
            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for(int i = 0; i < bytesFromFile.Length; i++)
            {
                bytesFromFile[i] = (byte) fStream.ReadByte();
                Console.Write($"{bytesFromFile[i],5}");
            }
            //Display decoded message;
            Console.Write("\nDecoded message: ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.ReadLine();
        }
    }
}
