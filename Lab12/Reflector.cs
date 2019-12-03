using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Reflector
    {
        public static void ToFile(Type t1, string name)
        {
            StreamWriter writer = new StreamWriter(@"D:\Lab\" + name + ".txt");
            //Type t1 = obj.GetType();
            writer.WriteLine($"Класс {t1.Name}");
            writer.WriteLine("Конструкторы:");
            foreach (var x in t1.GetConstructors())
            {
                writer.WriteLine(x);
            }
            writer.WriteLine("Методы:");
            foreach (var x in t1.GetMethods())
            {
                writer.WriteLine(x);
            }
            writer.WriteLine("Поля:");
            foreach (var x in t1.GetFields())
            {
                writer.WriteLine(x);
            }
            writer.Close();
        }

        public static void GetPublicMethods(Type t)
        {
            Console.WriteLine($"Public методы класса {t.Name}:");
            foreach(var x in t.GetMethods())
            {
                if (x.IsPublic)
                    Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static void GetField(Type t)
        {
            Console.WriteLine($"Поля и свойства класса {t.Name}");
            foreach(var x in t.GetFields())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach(var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }
    }
}
