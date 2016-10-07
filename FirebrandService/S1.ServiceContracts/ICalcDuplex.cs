using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    [ServiceContract(CallbackContract=typeof(ICalcDuplexCallback))]
    public interface ICalcDuplex
    {
        [OperationContract(IsOneWay = true)]
        void Divide(Numbers n);
    }

    public interface ICalcDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendAnswer(double answer);
    }
}
