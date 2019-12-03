using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.ToFile(typeof(Abiturient), "abiturient");
            Reflector.ToFile(typeof(Tablet), "tablet");

            Reflector.GetPublicMethods(typeof(Abiturient));
            Reflector.GetPublicMethods(typeof(Tablet));

            Reflector.GetField(typeof(Abiturient));
            Reflector.GetField(typeof(Tablet));
        }
    }
}
