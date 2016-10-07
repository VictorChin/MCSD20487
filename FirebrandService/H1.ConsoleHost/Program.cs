using System;
using System.ServiceModel;

namespace Firebrand
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Calculator)
                //, new Uri("http://localhost:801/Calc/")
                );

            host.Open();

            Console.WriteLine("Service {0} is listening on the following endpoints:",
                host.Description.Name);
            Console.WriteLine();

            foreach (var ep in host.Description.Endpoints)
            {
                Console.WriteLine("  Name: {0}", ep.Name);
                Console.WriteLine("    Address: {0}", ep.Address);
                Console.WriteLine("    Binding: {0}", ep.Binding);
                Console.WriteLine("    Contract: {0}", ep.Contract.ContractType);
                Console.WriteLine();
            }

            Console.WriteLine("Press ENTER to close.");
            Console.ReadLine(); // wait for ENTER
            Console.WriteLine("Closing...");
            host.Close();
            Console.WriteLine("Closed.");
        }
    }
}
