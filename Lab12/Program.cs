using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.ToFile("Abiturient", "abiturient");
            Reflector.ToFile("Tablet", "tablet");

            Reflector.GetPublicMethods("Abiturient");
            Reflector.GetPublicMethods("Tablet");

            Reflector.GetField("Abiturient");
            Reflector.GetField("Tablet");

            Reflector.GetInterfaces("Tablet");
            Reflector.GetInterfaces("Abiturient");

            Reflector.GetMethodsByParam("Abiturient", "System.String");
            Reflector.GetMethodsByParam("Tablet", "System.String");

            Reflector.CallMethodFromFile("Abiturient", "show");
        }
    }
}
