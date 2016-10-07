using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; // WCF core
using System.ServiceModel.Web; // so we can use WebGet

namespace Firebrand
{
    [ServiceContract]
    public interface ISampleService
    {
        // avoid having multiple arguments
        // - bad for versioning
        // - bad for REST-style endpoints
        [OperationContract]
        //[FaultContract(typeof(AddNumbersFault))]
        [WebGet] // pass parameters as a querystring
        double AddNumbers(double a, double b);

        // better to use a data contract
        [OperationContract]
        double Multiply(Numbers n);

        [OperationContract]
        string SayHello();
    }
}
