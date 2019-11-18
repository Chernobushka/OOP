using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    interface IMyInterface
    {
        string MyFunc();
    }

    interface IAnotherInterface
    {
        string ToString();
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Random random = new Random();
            Student student = new Student("name", "2");
            Dictionary<double, double> dictionary = new Dictionary<double, double>();
            Dictionary<double, Tablet> TabletDictionary = new Dictionary<double, Tablet>();
            Queue<double> queue = new Queue<double>();
            Queue<Tablet> TabletQueue = new Queue<Tablet>();
            Tablet[] arr = new Tablet[5];
            ObservableCollection<Tablet> tablets = new ObservableCollection<Tablet>();
            tablets.CollectionChanged += StaticClass.method;

            ArrayList list = new ArrayList(10)
            {
                10, 20, 30, 40, 50
            };
            list.Add("string");
            list.Add(student);
            list.RemoveAt(2);
            Console.WriteLine($"Nubmer of elements: {list.Count}");
            foreach (object x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"List contains 30 = {list.Contains(30)}");
            Console.WriteLine();

            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());

            foreach(KeyValuePair<double, double> x in dictionary)
            {
                Console.WriteLine(x);
                queue.Enqueue(x.Value);
            }
            Console.WriteLine();

            foreach (double x in queue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Tablet();
                TabletDictionary.Add(arr[i].GetHashCode(), arr[i]);
            }
            Console.WriteLine();

            foreach (KeyValuePair<double, Tablet> x in TabletDictionary)
            {
                Console.WriteLine(x);
                TabletQueue.Enqueue(x.Value);
            }
            Console.WriteLine();

            foreach(Tablet x in TabletQueue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            foreach (Tablet x in arr)
            {
                tablets.Add(x);
            }
            tablets.RemoveAt(3);
        }
    }
}
