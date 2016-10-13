using NorthwindModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {  
            NW ctx = new NW();
         
            ctx.Regions.Add(new Region
            {
                RegionDescription = "Somewhere"
            });
            ctx.SaveChanges();
        
        }
    }
}
