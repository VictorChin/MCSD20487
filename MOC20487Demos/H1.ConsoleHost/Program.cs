using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Firebrand
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(SampleService));
            host.Open(); // process .config and set up endpoints

            Console.WriteLine(host.Description.Name + " is listening on these endpoints:");
            Console.WriteLine();
            foreach (var ep in host.Description.Endpoints)
            {
                Console.WriteLine(" Name: " + ep.Name);
                Console.WriteLine("  Address: " + ep.Address);
                Console.WriteLine("  Binding: " + ep.Binding);
                Console.WriteLine("  Contract: " + ep.Contract.ContractType);
                Console.WriteLine();
            }

            Console.WriteLine("Press ENTER to close.");
            Console.ReadLine();
            Console.WriteLine("Closing... please wait.");
            host.Close();
            Console.WriteLine("Closed.");
        }
    }
}
