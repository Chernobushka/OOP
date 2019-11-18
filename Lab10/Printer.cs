using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
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

        public Printer(string organization, string product, string manufacturer, string inc) : base(organization, product, manufacturer)
        {
            IncType = inc;
        }
    }
}
