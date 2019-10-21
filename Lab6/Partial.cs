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

    public class Lab
    {
        Base[] elems;
        public int count = 0;
        public int size;

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
        }
    }

    public abstract class Base
    {
        struct Info
        {
            int price;
        }
        Info info = new Info();
    }
}
