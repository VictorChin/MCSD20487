using Microsoft.ServiceBus;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Mod07_ServiceBusRelay_Basic_HostServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(ProblemSolver));

            sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpBinding(),
               "net.tcp://localhost:9358/solver");

            sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpRelayBinding(),
               ServiceBusEnvironment.CreateServiceUri("sb", "chinzilla", "solver"))
                .Behaviors.Add(new TransportClientEndpointBehavior
                {
                    TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("UserPolicy", "7pmQbj+YhY43uOrPvdJ8BDXxdSjvrdko7ps42BuQk5k=")
                });

            sh.Open();

            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();

            sh.Close();
            //To Use App.config for host configuration, uncomment lines below
            //ServiceHost sh = new ServiceHost(typeof(ProblemSolver));
            //sh.Open();
            //Console.WriteLine("Press ENTER to close");
            //Console.ReadLine();
            //sh.Close();
            //To Use App.config for host configuration, uncomment lines above/
        }
    }
}
