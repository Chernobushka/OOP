using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ConsoleApp1
{
    class ASVFileManager
    {
        public static void MethodOne(string path)
        {
            DirectoryInfo disk = new DirectoryInfo(@"D:\");
            var directory = Directory.CreateDirectory(path);
            StreamWriter writer = new StreamWriter(path + @"ASVdirinfo.txt");
            writer.WriteLine("Files:");
            foreach (var x in disk.GetFiles())
            {
                writer.WriteLine(x.FullName);
            }
            writer.WriteLine("\nDirectories:");
            foreach (var x in disk.GetDirectories())
            {
                writer.WriteLine(x.Name);
            }
            writer.WriteLine();
            writer.Close();
        }

        public static void CopyDir(string path1, string path2)
        {
            if (Directory.Exists(path1))
            {
                DirectoryInfo dir1 = new DirectoryInfo(path1);
                DirectoryInfo dir2 = Directory.CreateDirectory(path2);

                foreach (var x in dir1.GetFiles())
                {
                    x.CopyTo(dir2.FullName + @"\" + x.Name);
                }
            }
            else
            {
                throw new Exception("There is no such directory!!!");
            }
        }
    }
}
