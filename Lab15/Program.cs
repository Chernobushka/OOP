using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Processes
            var AllProcesses = Process.GetProcesses();
            StreamWriter writer = new StreamWriter("processes.txt");

            try
            {
                foreach (var x in AllProcesses)
                {
                    Console.WriteLine($"{x.Id} {x.ProcessName} {x.BasePriority} {x.StartTime} {x.UserProcessorTime}");
                    writer.WriteLine($"{x.Id} {x.ProcessName} {x.BasePriority} {x.StartTime} {x.UserProcessorTime}");
                }
            }
            catch (Exception ex) { }
            Console.WriteLine();
            writer.Close();

            //Domain
            Console.WriteLine($"{AppDomain.CurrentDomain.FriendlyName} {AppDomain.CurrentDomain.SetupInformation}");
            Console.WriteLine($"Assemblies:");
            foreach (var x in AppDomain.CurrentDomain.GetAssemblies())
            {
                Console.WriteLine($"{x}");
            }

            //Thread
            Thread th = new Thread(new ParameterizedThreadStart(StaticClass.WriteNumbers));
            th.Name = th.ToString();
            th.Start(100);
            Thread.Sleep(1000);
            th.Suspend();
            Console.WriteLine($"{th.Name} {th.Priority} {th.ThreadState}");
            Thread.Sleep(2000);
            th.Resume();
        }
    }
}
