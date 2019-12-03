using System;
using System.Diagnostics;

namespace ConsoleApp1
{ 
    public interface IAnotherInterface
    {
        string ToString();
    }
    public interface IInterface
    {
        bool Equals(object obj);
        string ToString();
    }

    public abstract class Base
    {
        public struct Info
        {
            public int price;
        }
        public Info info = new Info();
    }

    class Product : Base, IAnotherInterface, IInterface
    {
        public string OrganizationName { get; set; }
        public string ProductName { get; set; }

        public Product()
        {
            OrganizationName = "NoName organization";
            ProductName = "NoName product";
        }

        public Product(string organization, string product, int price)
        {
            OrganizationName = organization;
            ProductName = product;
            info.price = price;
        }

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

    class Tech : Product, IAnotherInterface, IInterface
    {
        public string ManufacturerName { get; set; }
        public Tech() : base()
        {
            ManufacturerName = "NoName Manufacturer";
        }

        public Tech(string organization, string product, string manufacturer, int price) : base(organization, product, price)
        {
            ManufacturerName = manufacturer;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.ManufacturerName;
        }
    }

    abstract class Computer : Tech, IAnotherInterface, IInterface
    {
        public string OS { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + this.OS;
        }

        public Computer() : base()
        {
            OS = "NoName OS";
        }

        public Computer(string organization, string product, string manufacturer, string os, int price) : base(organization, product, manufacturer, price)
        {
            OS = os;
        }

        public abstract string MyFunc();
    }

    sealed class Printer : Tech, IAnotherInterface, IInterface
    {
        public string IncType { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + this.IncType;
        }

        public Printer() : base()
        {
            IncType = "NoName Inc";
        }

        public Printer(string organization, string product, string manufacturer, string inc, int price) : base(organization, product, manufacturer, price)
        {
            IncType = inc;
        }
    }

    class Scanner : Tech, IAnotherInterface, IInterface
    {
        public string DocType { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + this.DocType;
        }

        public Scanner() : base()
        {
            DocType = "NoName DocType";
        }

        public Scanner(string organization, string product, string manufacturer, string doc, int price) : base(organization, product, manufacturer, price)
        {
            DocType = doc;
        }
    }

    class Tablet : Computer, IAnotherInterface, IInterface
    {
        public string Resolution { get; set; }
        public override string MyFunc()
        {
            return "Переопределение";
        }

        public Tablet(string organization, string product, string manufacturer, string os, string res, int price) : base(organization, product, manufacturer, os, price)
        {
            Resolution = res;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Resolution;
        }
    }
}