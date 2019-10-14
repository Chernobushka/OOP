using System;

namespace ConsoleApp1
{
    interface IMyInterface
    {
        int MyFunc();
    }

    class Product
    {
        public string OrganizationName { get; set; }
        public string ProductName { get; set; }

        public Product()
        {
            OrganizationName = "NoName organization";
            ProductName = "NoName product";
        }

        public Product(string organization, string product)
        {
            OrganizationName = organization;
            ProductName = product;
        }

        public override bool Equals(object obj)
        {
            Product product = (Product)obj;
            return ((this.OrganizationName == product.OrganizationName) && (this.ProductName == product.ProductName));
        }

        public override int GetHashCode()
        {
            return OrganizationName.GetHashCode() + ProductName.GetHashCode();
        }

        public override string ToString()
        {
            return this.OrganizationName + " " + this.ProductName;
        }
    }

    class Tech : Product
    {
        public string ManufacturerName { get; set; }
        public Tech() : base()
        {
            ManufacturerName = "NoName Manufacturer";
        }

        public Tech(string organization, string product, string manufacturer) : base(organization, product)
        {
            ManufacturerName = manufacturer;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.ManufacturerName;
        }
    }

    abstract class Computer : Tech
    {
        public string OS { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + this.OS;
        }
    }

    sealed class Printer : Tech
    {
        public string IncType { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + this.IncType;
        }
    }

    class Scanner : Tech
    {
        public string DocType { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + this.DocType;
        }
    }

    class Tablet : Computer, IMyInterface
    {
        public string Resolution { get; set; }
        public int MyFunc()
        {
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Resolution;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("123", "213");
            Tech tech = new Tech("456", "789", "456789");

            Console.WriteLine(product.ToString());
            Console.WriteLine(tech.ToString());
        }
    }
}
