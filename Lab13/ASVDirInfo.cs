using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class ASVDirInfo
    {
        public static void ShowDirInfo(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo info = new DirectoryInfo(path);
                Console.WriteLine($"Directory name: {info.Name}");
                Console.WriteLine($"Directory path: {info.FullName}");
                Console.WriteLine($"Directory creation time: {info.CreationTime}");
                Console.WriteLine($"Number of files: {info.GetFiles().Length}");
                Console.WriteLine($"Number of subdirectories: {info.GetDirectories().Length}");
                Console.WriteLine();
            }
            else
            {
                throw new Exception($"Directory {path} does not exists!!!");
            }
        }
    }
}
