using System;

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

    partial class Product : Base, IAnotherInterface
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
    }

    class Tech : Product, IAnotherInterface
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

    abstract class Computer : Tech, IAnotherInterface
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

    sealed class Printer : Tech, IAnotherInterface
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

    class Scanner : Tech, IAnotherInterface
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

    class Tablet : Computer, IMyInterface, IAnotherInterface
    {
        public string Resolution { get; set; }
        public override string MyFunc()
        {
            return "Переопределение";
        }
        string IMyInterface.MyFunc()
        {
            return "Реализация метода интерфейса";
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Resolution;
        }
    }

    class Print
    {
        public static void IAmPrinting(IAnotherInterface obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("123", "213", 100);
            Tech tech = new Tech("456", "789", "456789", 200);
            Tablet tablet = new Tablet();
            Lab lab = new Lab(6);
            Scanner scanner = new Scanner("2223", "32131", "11123", "231", 22360);
            tablet.info.price = 300;
            IAnotherInterface[] arr = new IAnotherInterface[3];
            arr[0] = product;
            arr[1] = tech;
            arr[2] = tablet;

            try
            {
                Lab WrongLab = new Lab(100);
                WrongLab.Del(tablet);
                //arr[4].ToString();
                lab.Add(product);
                lab.Add(tech);
                lab.Add(tablet);
                lab.Add(new Scanner());
                lab.Add(new Printer());
                lab.Add(new Product());
                //lab.Add(new Product());
            

                lab.show();
                controller.show(lab);
                controller.sort(lab);
                lab.show();
                lab.Del(tablet);
                //lab.Del(scanner);
                lab.show();
            }
            catch (LabIsFull ex)
            {
                Console.WriteLine("LabIsFull Exception");
                Console.WriteLine(ex.Message);
            }
            catch (ElementDoesNotExist ex)
            {
                Console.WriteLine("ElementDoesNotExist Exception");
                Console.WriteLine(ex.Message);
            }
            catch (LabIsEmpty ex)
            {
                Console.WriteLine("LabIsEmpty Exception");
                Console.WriteLine(ex.Message);
            }
            catch (WrongSize ex)
            {
                Console.WriteLine("WrongSize Exception");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Another Exception");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
