using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class ASVLog
    {
        private string path;
        private StreamWriter writer;
        private FileSystemWatcher watcher = new FileSystemWatcher(@"D:\");

        public ASVLog(string _path)
        {
            path = _path;
            writer = new StreamWriter(path);
            watcher.Changed += OnChange;
        }

        private void OnChange(object source, FileSystemEventArgs e) => 
            writer.WriteLine($"{DateTime.Now} {e.FullPath} {e.ChangeType}");

        public void close() =>
            writer.Close();
    }
}
