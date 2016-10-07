using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    public class DuplexCalc : ICalcDuplex
    {
        public void Divide(Numbers n)
        {
            var client = OperationContext.Current
                .GetCallbackChannel<ICalcDuplexCallback>();

            client.SendAnswer(n.A / n.B);
        }
    }
}
