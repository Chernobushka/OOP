using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    [DataContract]
    public class Product : IAnotherInterface
    {
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
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
            return this.OrganizationName.GetHashCode() + this.ProductName.GetHashCode();
        }

        public override string ToString()
        {
            return this.OrganizationName + " " + this.ProductName;
        }
    }
}
