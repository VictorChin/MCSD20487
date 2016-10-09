using Microsoft.ServiceBus;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter when server is ready");
            Console.ReadLine();
            var cf = new ChannelFactory<IProblemSolver>(
    new NetTcpRelayBinding(),
    new EndpointAddress(ServiceBusEnvironment.CreateServiceUri("sb", "chinzilla", "solver")));

            cf.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior
            { TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("UserPolicy", "7pmQbj+YhY43uOrPvdJ8BDXxdSjvrdko7ps42BuQk5k=") });
            var ch = cf.CreateChannel();
            Console.WriteLine(ch.AddNumbers(4, 5));
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
