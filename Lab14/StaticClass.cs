using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    static class StaticClass
    {
        public static void method(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection changed!");
        }
    }
}
