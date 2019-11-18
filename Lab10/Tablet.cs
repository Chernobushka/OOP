using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tablet : Computer, IMyInterface, IAnotherInterface
    {
        static int count = 0;
        public string Resolution { get; set; }

        public Tablet()
        {
            ProductName = "Tablet " + (count++);
        }

        ~Tablet()
        {
            count--;
        }

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
            return this.ProductName;
        }
    }
}
