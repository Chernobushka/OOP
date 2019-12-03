using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    partial class Abiturient
    {
        private readonly int id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int[] Marks { get; set; }
        public const string University = "BSTU";
        public static int count;

        static Abiturient()
        {
            count = 0;
        }
        public Abiturient()
        {
            id = count;
            FirstName = "Student " + count++;
            LastName = "Student";
        }
        public Abiturient(string _FirstName, string _LastName) : this()
        {
            FirstName = _FirstName;
            LastName = _LastName;
            id = FirstName.GetHashCode() + LastName.GetHashCode();
        }
        public Abiturient(string _FirstName, string _LastName, int[] _Marks) : this()
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Marks = _Marks;
            id = FirstName.GetHashCode() + LastName.GetHashCode();
        }

        public double getAvg()
        {
            double sum = 0;
            foreach (int x in Marks)
            {
                sum += x;
            }
            return (sum / Marks.Length);
        }

        public int getMin()
        {
            int min = Marks[0];
            foreach (int x in Marks)
            {
                if (x <= min)
                {
                    min = x;
                }
            }
            return min;
        }

        public int getMax()
        {
            int max = Marks[0];
            foreach (int x in Marks)
            {
                if (x >= max)
                {
                    max = x;
                }
            }
            return max;
        }

        public int getSum()
        {
            int sum = 0;
            foreach (int x in Marks)
            {
                sum += x;
            }
            return sum;
        }
    }

    partial class Abiturient
    {
        public static int getCount()
        {
            return count;
        }

        public override bool Equals(object obj)
        {
            Abiturient abitur = (Abiturient)obj;
            return ((this.FirstName == abitur.FirstName) && (this.LastName == abitur.LastName) && (this.Adress == abitur.Adress));
        }

        public override string ToString()
        {
            return (this.FirstName + " " + this.LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() + this.LastName.GetHashCode();
        }
    }
}
