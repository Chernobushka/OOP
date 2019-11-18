using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tech : Product, IAnotherInterface
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
}
