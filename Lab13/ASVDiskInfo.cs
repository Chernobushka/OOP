using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class ASVDiskInfo
    {
        public static void ShowFreeSpace()
        {
            var AllDrives = DriveInfo.GetDrives();
            foreach (var x in AllDrives)
            {
                if (x.IsReady)
                {
                    Console.WriteLine($"Drive name: {x.Name}");
                    Console.WriteLine($"Available space: {x.AvailableFreeSpace}");
                    Console.WriteLine();
                }
            }
        }

        public static void ShowFileSystem()
        {
            var AllDrives = DriveInfo.GetDrives();
            foreach (var x in AllDrives)
            {
                if (x.IsReady)
                {
                    Console.WriteLine($"Drive name: {x.Name}");
                    Console.WriteLine($"File system: {x.DriveFormat}");
                    Console.WriteLine();
                }
            }
        }

        public static void ShowDiskInfo()
        {
            var AllDrives = DriveInfo.GetDrives();
            foreach (var x in AllDrives)
            {
                if (x.IsReady)
                {
                    Console.WriteLine($"Drive name: {x.Name}");
                    Console.WriteLine($"Dirve size: {x.TotalSize}");
                    Console.WriteLine($"Dirve total free space: {x.TotalFreeSpace}");
                    Console.WriteLine($"Dirve volume label: {x.VolumeLabel}");
                    Console.WriteLine();
                }
            }
        }
    }
}
