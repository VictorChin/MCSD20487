using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    //[ServiceBehavior(InstanceContextMode=InstanceContextMode.Single,
    //    ConcurrencyMode=ConcurrencyMode.Reentrant)]
    public class SampleService : ISampleService
    {
        public double AddNumbers(double a, double b)
        {
            if ((a == 13) || (b == 13))
            {
                //throw new ArgumentException("13 is unlucky!");
                var fault = new AddNumbersFault();
                fault.FavouriteColour = "Red";
                fault.FavouriteNumbers = new Numbers { A = 4.5 };
                var reason = new FaultReason("13 is unlucky!");
                throw new FaultException<AddNumbersFault>(
                    fault, reason);
            }
            return a + b;
        }

        public double Multiply(Numbers n)
        {
            return n.A * n.B;
        }

        public string SayHello()
        {
            return "Hello from SampleService hosted in Console (" + DateTime.Now.ToLongTimeString() + ")";
        }
    }
}
