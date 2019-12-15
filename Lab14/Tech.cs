using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Tech : Product, IAnotherInterface
    {
        [DataMember]
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
