using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
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

        public Computer(string organization, string product, string manufacturer, string os) : base(organization, product, manufacturer)
        {
            OS = os;
        }

        public abstract string MyFunc();
    }
}
