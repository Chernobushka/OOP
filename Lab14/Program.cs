using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner tablet = new Scanner();
            BinaryFormatter formatter = new BinaryFormatter();
            SoapFormatter soapFormatter = new SoapFormatter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Scanner));
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Scanner));
            DataContractJsonSerializer jsonSerializerForList = new DataContractJsonSerializer(typeof(List<Scanner>));
            List<Scanner> list = new List<Scanner>();

            //Binary formatter
            using (FileStream fs = new FileStream("tablet.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,  tablet);
            }

            using (FileStream fs = new FileStream("tablet.dat", FileMode.OpenOrCreate))
            {
                Scanner DeserializedTablet = (Scanner)formatter.Deserialize(fs);
                Console.WriteLine(DeserializedTablet);
            }

            //Soap formatter
            using (FileStream fs = new FileStream("soap.dat", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, tablet);
            }

            using (FileStream fs = new FileStream("soap.dat", FileMode.OpenOrCreate))
            {
                Scanner DeserializedScanner = (Scanner)soapFormatter.Deserialize(fs);
                Console.WriteLine(DeserializedScanner);
            }

            //XML Serializer
            using (FileStream fs = new FileStream("xml.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, tablet);
            }

            using (FileStream fs = new FileStream("xml.xml", FileMode.OpenOrCreate))
            {
                Scanner DeserializedScanner = (Scanner)xmlSerializer.Deserialize(fs);
                Console.WriteLine(DeserializedScanner);
            }

            //Json Serializer
            using (FileStream fs = new FileStream("json.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, tablet);
            }

            using (FileStream fs = new FileStream("json.json", FileMode.OpenOrCreate))
            {
                Scanner DeserializedScanner = (Scanner)jsonSerializer.ReadObject(fs);
                Console.WriteLine(DeserializedScanner);
            }
            Console.WriteLine();

            //List serialization
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());
            list.Add(new Scanner());

            using (FileStream fs = new FileStream("list.json", FileMode.OpenOrCreate))
            {
                jsonSerializerForList.WriteObject(fs, list);
            }

            using (FileStream fs = new FileStream("list.json", FileMode.OpenOrCreate))
            {
                List<Scanner> DeserializedList = (List<Scanner>)jsonSerializerForList.ReadObject(fs);
                foreach(var x in DeserializedList)
                {
                    Console.WriteLine(x);
                }
            }

            //LINQ to XML
            XDocument newXmlDoc = new XDocument(new XElement("books",
                new XElement("book",
                new XElement("title", "123"),
                new XElement("Author","456"),
                new XElement("Price", 200)),
                new XElement("book",
                new XElement("title", "qwe"),
                new XElement("Author", "qwe"),
                new XElement("Price", 400)),
                new XElement("book",
                new XElement("title", "asd"),
                new XElement("Author", "asd"),
                new XElement("Price", 600)), 
                new XElement("book",
                new XElement("title", "zxc"),
                new XElement("Author", "zxc"),
                new XElement("Price", 800))
                ));
            newXmlDoc.Save("LinqXml.xml");

        }
    }
}
