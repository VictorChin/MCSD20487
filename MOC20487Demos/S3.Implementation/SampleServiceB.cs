using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    // this implementation is hosted in the H2.IISHost for testing routing backuplists
    public class SampleServiceB : ISampleService
    {
        public double AddNumbers(double a, double b)
        {
            return a + b;
        }

        public double Multiply(Numbers n)
        {
            return n.A * n.B;
        }

        public string SayHello()
        {
            return "Hello from SampleService hosted in IIS (" + DateTime.Now.ToLongTimeString() + ")";
        }
    }
}
