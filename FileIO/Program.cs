using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadRec();
            // XmlSerial();
            StreamReader reader = new StreamReader("");
            XmlSerializer xml = new XmlSerializer(typeof(Product);
            Product p = new Product();
            p = (Product)xml.Deserialize(reader);

        }

        private static void XmlSerial()
        {
            Product p = new Product();
            p.ProductID = 111;
            p.Name = "IPhone X";
            p.cost = 90000;
            StreamWriter write = new StreamWriter("", true);
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            xml.Serialize(write, p);
            write.Close();
        }

        private static void ReadRec()
        {
            //NewMethod();
            StreamReader reader = new StreamReader("jdjd");
            string itemR = reader.ReadLine();
            Product p = new Product();
            string[] item = itemR.Split(',');
            p.ProductID = int.Parse(item[0]);
            p.Name = item[1];
            p.cost = int.Parse(item[2]);
        }

        private static void WriteRec()
        {
            Product p = new Product();
            p.ProductID = 111;
            p.Name = "IPhone X";
            p.cost = 90000;
            StreamWriter write = new StreamWriter("");
            string item = $"{p.ProductID},{p.Name},{p.cost}";
            write.WriteLine(item);
            
        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int cost { get; set; }

    }
}
