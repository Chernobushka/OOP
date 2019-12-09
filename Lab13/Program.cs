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
                ASVLog log = new ASVLog(@"D:\Log.txt");
                StreamWriter str;
                string str1;
                
                ASVDiskInfo.ShowFreeSpace();
                ASVDiskInfo.ShowFileSystem();
                ASVDiskInfo.ShowDiskInfo();

                ASVFileInfo.ShowFullPath(@"D:\123.bmp");
                ASVFileInfo.ShowFullPath(@"dxwebsetup.exe");
                ASVFileInfo.ShowFileInfo(@"D:\123.bmp");
                ASVFileInfo.ShowFileInfo(@"dxwebsetup.exe");

                ASVDirInfo.ShowDirInfo(@"D:\Универ\Лабы");

                ASVFileManager.MethodOne(@"D:\ASVInspect\");
                ASVFileManager.CopyDir(@"D:\ASVInspect\", @"D:\ASVFile");

                str1 = Console.ReadLine();
                while (str1 != "q")
                {
                    str = new StreamWriter(@"D:\11.txt");
                    str.WriteLine(str1);
                    str1 = Console.ReadLine();
                    str.Close();
                }

                log.close();
                log.GetByCurrentMinute(@"D:\FinalLog.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
