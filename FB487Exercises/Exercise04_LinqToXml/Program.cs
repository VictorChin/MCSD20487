using System;
using System.Xml.Linq;
using System.Linq;
using System.Diagnostics;
using Exercise00_Recorder;

namespace Exercise04_LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Recorder.Start();

            var db = new Northwind();
            var products = db.Products.ToArray();

            var xml = new XElement("products",
                products.Select(p => new XElement("product",
                    new XAttribute("id", p.ProductID),
                    new XAttribute("price", p.UnitPrice),
                    new XAttribute("discontinued", p.Discontinued),
                    new XAttribute("categoryid", p.CategoryID),
                    new XElement("name", p.ProductName),
                    new XElement("unitsinstock", p.UnitsInStock)
                )));

            xml.Save("products.xml");

            Console.WriteLine(System.IO.File.ReadAllText("products.xml"));

            var recording = Recorder.Stop(true);
        }
    }
}
