using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml;
using D2.ClassicDataDemo.Models.NorthwindDataSetTableAdapters;
using D2.ClassicDataDemo.Models;
using System.Data;

namespace D2.ClassicDataDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/SqlDataReaderDemo

        [OutputCache(Location = OutputCacheLocation.None)]
        public async Task<ActionResult> SqlDataReaderDemoAsync()
        {
            var sb = new StringBuilder();
            var con = new SqlConnection(@"Data Source=(localdb)\v11.0;" +
                "Initial Catalog=Northwind;Integrated Security=true;");
            var cmd = new SqlCommand("WAITFOR DELAY '00:00:05';" +
                "SELECT * FROM Products", con);
            await con.OpenAsync();
            var r = await cmd.ExecuteReaderAsync();
            var iID = r.GetOrdinal("ProductID");
            var iName = r.GetOrdinal("ProductName");
            var iPrice = r.GetOrdinal("UnitPrice");
            while (await r.ReadAsync())
            {
                sb.AppendFormat("{0}: {1} costs {2:c}", 
                    await r.GetFieldValueAsync<int>(iID), 
                    await r.GetFieldValueAsync<string>(iName), 
                    await r.GetFieldValueAsync<decimal>(iPrice));
            }
            r.Close();
            con.Close();
            return Content(sb.ToString());
        }

        //
        // GET: /Home/XmlReaderDemo

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult XmlReaderDemo()
        {
            var path = Server.MapPath(@"~\App_Data\");
            var sb = new StringBuilder();
            var settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("", path + "books.xsd");
            settings.ValidationEventHandler += (sender, e) => { sb.AppendFormat(@"{0}: {1}<br \>", e.Severity, e.Message); };

            var reader = XmlReader.Create(path + "books.xml", settings);
            while (reader.Read())
            {
                //sb.AppendFormat("{0} is a {1}", reader.Name,reader.NodeType);

                switch (reader.NodeType)
                {
                    case XmlNodeType.Comment:
                        sb.AppendFormat(@"Comment: {0}<br \>", reader.Value);
                        break;
                    case XmlNodeType.Element:
                        sb.AppendFormat(@"Element: {0}<br \>", reader.Name);
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                sb.AppendFormat(@"Attribute: {0}={1}<br \>", reader.Name, reader.Value);
                            }
                        }
                        break;
                    case XmlNodeType.EndElement:
                        sb.AppendFormat(@"EndElement: {0}<br \>", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        sb.AppendFormat(@"Text: {0}<br \>", reader.Value);
                        break;
                }
            }
            reader.Close();
            return Content(sb.ToString());
        }
        
        //
        // GET: /Home/XmlReaderDemo

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult XmlWriterDemo()
        {
            var path = Server.MapPath(@"~\App_Data\");

            var settings = new XmlWriterSettings();
            settings.Indent = true;
            var writer = XmlWriter.Create(path + "zoo.xml", settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("zoo");
            writer.WriteElementString("location", "Regent's Park");

            writer.WriteStartElement("lion");
            writer.WriteAttributeString("age", "4");
            writer.WriteElementString("name", "Leo");
            writer.WriteElementString("colour", "golden");
            writer.WriteEndElement();

            writer.WriteElementString("elephant", "Nellie");

            writer.WriteStartElement("giraffe");
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            return Content(System.IO.File.ReadAllText(path + "zoo.xml"));
        }

        ShippersTableAdapter ta = new ShippersTableAdapter();
        NorthwindDataSet ds = new NorthwindDataSet();

        //
        // GET: /Home/FillDataSetFromDatabase

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult FillDataSetFromDatabase()
        {
            ta.Fill(ds.Shippers);
            Session["dataset"] = ds;
            return View("ShippersList", ds.Shippers.AsEnumerable());
        }

        //
        // GET: /Home/UpdateDatabaseFromDataSet

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult UpdateDatabaseFromDataSet()
        {
            ds = Session["dataset"] as NorthwindDataSet;
            int rows = ta.Update(ds.Shippers);
            return Content(rows + " row(s) affected.");
        }

        //
        // GET: /Home/WriteDataSetToXml

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult WriteDataSetToXml()
        {
            ds = Session["dataset"] as NorthwindDataSet;
            var path = Server.MapPath(@"~\App_Data\");
            ds.WriteXml(path + "shippers.xml", XmlWriteMode.DiffGram);
            return File(path + "shippers.xml", "text/xml");
        }

        //
        // GET: /Home/ReadDataSetFromXml

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult ReadDataSetFromXml()
        {
            var path = Server.MapPath(@"~\App_Data\");
            ds.ReadXml(path + "shippers.xml", XmlReadMode.DiffGram);
            Session["dataset"] = ds;
            return View("ShippersList", ds.Shippers.AsEnumerable());
        }

    }
}
