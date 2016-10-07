using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise05_StoredProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\v11.0";
            builder.InitialCatalog = "Northwind";
            builder.IntegratedSecurity = true;

            var connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            // create stored procedures

            var command = new SqlCommand("DROP PROCEDURE dbo.GetAllProducts", connection);
            command.ExecuteNonQuery();

            command.CommandText = "CREATE PROCEDURE dbo.GetAllProducts AS SELECT * FROM Products RETURN 0;";
            command.ExecuteNonQuery();

            command.CommandText = "DROP PROCEDURE dbo.GetProductsCostingMoreThan";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE PROCEDURE dbo.GetProductsCostingMoreThan @Cost money AS " +
                "SELECT * FROM Products WHERE UnitPrice > @Cost; DECLARE @RV int; SELECT @RV = COUNT(*) FROM Products WHERE UnitPrice > @Cost; RETURN @RV;";
            command.ExecuteNonQuery();


        }
    }
}
