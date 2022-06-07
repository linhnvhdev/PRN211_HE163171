using System;
using System.Linq;
using System.Diagnostics;

namespace ProcessExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            listAllRunningProcess();
            // ----------------Demonstrate list thread and modules
            /*
            GetSpecificProcess();
            Console.WriteLine("***** Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);
            EnumThreadsForPid(theProcID);
            EnumModsForPid(theProcID);
            Console.ReadLine();
            */
            // ---------------- Demonstrate start and kill process
            //StartAndKillProcess();
            //StartAndKillProcess2();
            // ---------------- Demonstrate App verb
            UseApplicationVerbs();
        }

        static void listAllRunningProcess()
        {
            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            foreach (var proc in runningProcs)
            {
                string info = $"-> PID: {proc.Id}\tName: {proc.ProcessName}";
                Console.WriteLine(info);
            }
        }

        static void GetSpecificProcess()
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(123);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection threads = theProc.Threads;
            foreach(ProcessThread thread in threads)
            {
                string info = $"-> Thread ID: {thread.Id}\tStart Time: {thread.StartTime.ToShortTimeString()}\tPriority:{thread.PriorityLevel}";
                Console.WriteLine(info);
            }

        }

        static void EnumModsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Here are the loaded modules for: {0}",
            theProc.ProcessName);
            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                string info = $"-> Mod Name: {pm.ModuleName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }

        static void StartAndKillProcess()
        {
            Process proc = null;
            // Launch Edge, and go to Facebook!
            try
            {
                proc = Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "www.facebook.com");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("--> Hit enter to kill {0}...",
            proc.ProcessName);
            Console.ReadLine();
            // Kill all of the msedge.exe processes.
            try
            {
                foreach (var p in Process.GetProcessesByName("MsEdge"))
                {
                    p.Kill(true);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void StartAndKillProcess2()
        {
            Process proc = null;
            // Launch Microsoft Edge, and go to Facebook, with maximized window.
            try
            {
                ProcessStartInfo startInfo = new
                ProcessStartInfo("MsEdge", "www.facebook.com");
                startInfo.UseShellExecute = true;
                proc = Process.Start(startInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void UseApplicationVerbs()
        {
            int i = 0;
            //adjust this path and name to a document on your machine
            ProcessStartInfo si =
            new ProcessStartInfo(@"E:\Documents\test.png");
            foreach (var verb in si.Verbs)
            {
                Console.WriteLine($" {i++}. {verb}");
            }
            si.WindowStyle = ProcessWindowStyle.Normal;
            si.Verb = "Edit";
            si.UseShellExecute = true;
            Process.Start(si);
        }
    }
}
