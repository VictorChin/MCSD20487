using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Firebrand
{
    [ServiceContract(CallbackContract = typeof(ICalcCallback))]
    public interface ICalcDuplex
    {
        [OperationContract(IsOneWay = true)]
        void DivideNumbers(double a, double b);
    }

    public interface ICalcCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendAnswer(double answer);
    }
}
