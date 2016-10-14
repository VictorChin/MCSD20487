using NorthwindModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using EFConsoleClient;
namespace EFConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NW())
            {
                ctx.Database.Log = (msg) => Console.WriteLine(msg);
                var result = ctx.CollectionFromSql(
                    "dbo.[Customers By City] @param1",
                    new Dictionary<string, object> { { "@param1","London"} });
                foreach (var item in result)
                {
                    Console.WriteLine("{0}", item.ContactName);

                }
                    //ctx.Categories.Where(c=>c.CategoryID<5).ForEachAsync(
                    //    (c) => Console.WriteLine("{0}",c.CategoryName)
                    //    );
                }
            Console.ReadLine();
        
        }
    }
}
