using System;
using System.IO;

namespace DirectoryInfoClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\Documents\HocFPT\PRN211\Code\InClass\PRN211_HE163171\Week 4");
            Console.WriteLine("Search pattern *Demo returns:");
            foreach (var fi in di.GetDirectories("*Demo"))
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Search pattern TopDirectoryOnly returns:");
            foreach(var fi in di.GetFiles("*.json", SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
