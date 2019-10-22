using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    partial class Product
    {
        public override bool Equals(object obj)
        {
            Product product = (Product)obj;
            return ((this.OrganizationName == product.OrganizationName) && (this.ProductName == product.ProductName));
        }

        public override int GetHashCode()
        {
            return this.OrganizationName.GetHashCode() + this.ProductName.GetHashCode();
        }

        public override string ToString()
        {
            return this.OrganizationName + " " + this.ProductName;
        }
    }

    enum list
    {
        one = 1,
        two,
        three,
        nine = 9,
        ten
    }

    public class Lab
    {
        public Base[] elems;
        public int count = 0;
        public int size;
        list list = new list();

        public Lab()
        {
            size = 100;
            elems = new Base[100];
        }

        public Lab(int c)
        {
            size = c;
            elems = new Base[c];
        }

        public bool isFull()
        {
            return (count == size);
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public void Add(Base el)
        {
            if (isFull())
                return;
            elems[count++] = el;
        }

        public void Del(Base el)
        {
            int num = 0;
            if (isEmpty())
                return;
            for (int i = 0; i < count; i++)
            {
                if (elems[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                elems[i] = elems[i + 1];
            }
            count--;
        }

        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(elems[i].ToString());     
            }
            Console.WriteLine();
        }
    }

    public abstract class Base
    {
        public struct Info
        {
            public int price;
        }
        public Info info = new Info();
    }

    public static class controller
    {
        public static void sort(Lab lab)
        {
            Base elem;
            for (int i = 0; i < lab.count - 1; i++)
            {
                for (int j = 0; j < lab.count - i - 1; j++)
                {
                    if (lab.elems[j].info.price < lab.elems[j + 1].info.price)
                    {
                        elem = lab.elems[j];
                        lab.elems[j] = lab.elems[j + 1];
                        lab.elems[j + 1] = elem;
                    }
                }
            }
        }

        public static void show(Lab lab)
        {
            string[] products = new string[6];
            int[] count = new int[6];
            int pos = 0;
            bool b = false;
            for (int j = 0; j < lab.count; j++)
            {
                for (int i = 0; i < pos; i++)
                {
                    if (products[i] == (lab.elems[j].GetType()).Name)
                    {
                        b = true;
                        count[i]++;
                        break;
                    }
                }
                if (!b)
                {
                    products[pos] = lab.elems[j].GetType().Name;
                    count[pos]++;
                    pos++;
                }
                b = false;
            }

            Console.WriteLine("Lab elements:");
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($"{products[i]} - {count[i]}");
            }
            Console.WriteLine();
        }
    }
}
