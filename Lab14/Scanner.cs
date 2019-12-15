using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    [DataContract]
    public class Scanner : Tech, IAnotherInterface
    {
        [DataMember]
        public string DocType { get; set; }
        static public int count = 0;
        public override string ToString()
        {
            return base.ToString() + " " + this.DocType;
        }

        public Scanner() : base()
        {
            DocType = $"NoName DocType {count++}";
        }

        public Scanner(string organization, string product, string manufacturer, string doc) : base(organization, product, manufacturer)
        {
            DocType = doc;
        }
    }
}
