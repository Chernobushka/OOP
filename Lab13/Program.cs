using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ASVLog log = new ASVLog(@"D:\Lab.txt");
                StreamWriter str = new StreamWriter(@"D:\11.txt");
                str.WriteLine(1111);
                str.Close();

                ASVDiskInfo.ShowFreeSpace();
                ASVDiskInfo.ShowFileSystem();
                ASVDiskInfo.ShowDiskInfo();

                ASVFileInfo.ShowFullPath(@"D:\123.bmp");
                ASVFileInfo.ShowFullPath(@"dxwebsetup.exe");
                ASVFileInfo.ShowFileInfo(@"D:\123.bmp");
                ASVFileInfo.ShowFileInfo(@"dxwebsetup.exe");

                ASVDirInfo.ShowDirInfo(@"D:\Универ\Лабы");

                log.close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
