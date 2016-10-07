using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.Diagnostics;

namespace Exercise02_XmlToRelational
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\v11.0";
            builder.InitialCatalog = "Northwind";
            builder.IntegratedSecurity = true;

            var connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            var sql = "IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID('dbo.BackupProducts') AND sysstat & 0xf = 3)"
                + "DROP TABLE [dbo].[BackupProducts]";
            
            var command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            sql = "CREATE TABLE [dbo].[BackupProducts] (" +
                    "[ProductID]    INT          NOT NULL," +
                    "[ProductName]  NVARCHAR(40) NOT NULL," +
                    "[CategoryID]   INT          NULL," +
                    "[UnitPrice]    MONEY        NULL," +
                    "[UnitsInStock] SMALLINT     NULL," +
                    "[Discontinued] BIT          NOT NULL" +
                ");";
            command.CommandText = sql;
            command.ExecuteNonQuery();

            var settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            var reader = XmlReader.Create("products.xml", settings);

            while(reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.LocalName == "product"))
                {
                    var id = reader.GetAttribute("id");
                    var price = reader.GetAttribute("price");
                    var discontinued = bool.Parse(reader.GetAttribute("discontinued")) ? 1 : 0;
                    var categoryid = reader.GetAttribute("categoryid");
                    reader.Read();
                    var name = reader.ReadElementContentAsString();
                    name = name.Replace("'", "''");
                    var stock = reader.ReadElementContentAsString();
                    sql = "INSERT INTO BackupProducts (ProductID, UnitPrice, Discontinued, CategoryID, ProductName, UnitsInStock) " +
                        string.Format("VALUES({0}, {1}, {2}, {3}, '{4}', {5});", id, price, discontinued, categoryid, name, stock);
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
            reader.Close();
        }
    }
}
