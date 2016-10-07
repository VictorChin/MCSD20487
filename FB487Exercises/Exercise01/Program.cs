using System;
using System.Xml;
using System.Data.SqlClient;
using Exercise00_Recorder;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Recorder.Start();

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\v11.0";
            builder.InitialCatalog = "Northwind";
            builder.IntegratedSecurity = true;
            
            var connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            var sql = "SELECT ProductID, ProductName, UnitPrice, Discontinued, UnitsInStock, CategoryID FROM Products";
            var command = new SqlCommand(sql, connection);

            var reader = command.ExecuteReader();

            var settings = new XmlWriterSettings();
            settings.Indent = true;

            var writer = XmlWriter.Create("products.xml", settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("products");

            int iID = reader.GetOrdinal("ProductID");
            int iName = reader.GetOrdinal("ProductName");
            int iPrice = reader.GetOrdinal("UnitPrice");
            int iDisc = reader.GetOrdinal("Discontinued");
            int iStock = reader.GetOrdinal("UnitsInStock");
            int iCatID = reader.GetOrdinal("CategoryID");

            while(reader.Read())
            {
                writer.WriteStartElement("product");
                writer.WriteAttributeString("id", reader.GetFieldValue<int>(iID).ToString());
                writer.WriteAttributeString("price", reader.GetFieldValue<decimal>(iPrice).ToString());
                writer.WriteAttributeString("discontinued", reader.GetFieldValue<bool>(iDisc).ToString());
                writer.WriteAttributeString("categoryid", reader.GetFieldValue<int>(iCatID).ToString());
                writer.WriteElementString("name", reader.GetFieldValue<string>(iName).ToString());
                writer.WriteElementString("unitsinstock", reader.GetFieldValue<short>(iStock).ToString());
                writer.WriteEndElement();
            }

            reader.Close();
            connection.Close();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            Console.WriteLine(System.IO.File.ReadAllText("products.xml"));

            var recording = Recorder.Stop(true);
        }
    }
}
