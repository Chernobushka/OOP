using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class ASVFileInfo
    {
        public static void ShowFullPath(string path)
        {
            if (File.Exists(path))
            {
                FileInfo file = new FileInfo(path);
                Console.WriteLine($"Full path to file: {file.FullName}");
                Console.WriteLine();
            }
            else
            {
                throw new Exception("There is no such file!!");
            }
        }

        public static void ShowFileInfo(string path)
        {
            if (File.Exists(path))
            {
                FileInfo file = new FileInfo(path);
                Console.WriteLine($"Full path to file: {file.FullName}");
                Console.WriteLine($"File name: {file.Name}");
                Console.WriteLine($"File size: {file.Length}");
                Console.WriteLine($"File extention: {file.Extension}");
                Console.WriteLine($"File creation time: {file.CreationTime}");
                Console.WriteLine();
            }
            else
            {
                throw new Exception($"File {path} does not exists!!!");
            }
        }
    }
}
