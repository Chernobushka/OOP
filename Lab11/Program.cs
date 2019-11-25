using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<Abiturient> AbiturientList = new List<Abiturient>();
            int[][] marks = new int[3][];
            marks[0] = new int[4] { 3, 2, 4, 6 };
            marks[1] = new int[4] { 7, 8, 8, 7 };
            marks[2] = new int[4] { 9, 8, 9, 8 };
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[12] { "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November" };
            IEnumerable<string> monthes = from x in arr
                                          where x.Length < n
                                          select x;
            IEnumerable<string> WinterAndSummer = arr.Take(3);
            foreach(string x in monthes)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in WinterAndSummer)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            AbiturientList.Add(new Abiturient("Bad", "Student", marks[0]));
            AbiturientList.Add(new Abiturient("Normal", "Student", marks[1]));
            AbiturientList.Add(new Abiturient("Good", "Student", marks[2]));
            AbiturientList.Add(new Abiturient("Avg", "Student 1", new int[4] { 6, 5, 4, 5}));
            AbiturientList.Add(new Abiturient("Avg", "Student 2", new int[4] { 7, 7, 6, 5}));

            Console.WriteLine("Bad students:");
            IEnumerable<Abiturient> BadStudents = from x in AbiturientList
                                                  where x.getMin() < 4
                                                  select x;
            foreach(Abiturient x in BadStudents)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.Write("Сумма баллов выше заданной:\nВведите число: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Abiturient> SumAbiturients = from x in AbiturientList
                                                     where x.getSum() > sum
                                                     select x;
            foreach(Abiturient x in SumAbiturients)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("Упорядоченные по алфавиту:");
            IEnumerable<Abiturient> AlphabetAbiturients = AbiturientList.OrderBy(s => s.LastName).ThenBy(s => s.FirstName);
            foreach (Abiturient x in AlphabetAbiturients)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("3 с самой низкой успеваемостью");
            IEnumerable<Abiturient> BadAvgAbiturinets = AbiturientList.OrderBy(s => s.getAvg()).Take(3);
            foreach (Abiturient x in BadAvgAbiturinets)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
