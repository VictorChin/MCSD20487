using System.ServiceModel;
using System.ServiceModel.Web;
namespace Firebrand
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        [FaultContract(typeof(AddFault))]
        [WebGet]
        // it is BAD to have multiple parameters
        double Add(double a, double b);

        [OperationContract]
        // if is BETTER to have a single complex parameter
        // by using a data contract
        double Multiply(Numbers n);
    }
}
