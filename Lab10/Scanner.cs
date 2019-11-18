using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
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

        public Scanner(string organization, string product, string manufacturer, string doc) : base(organization, product, manufacturer)
        {
            DocType = doc;
        }
    }
}
