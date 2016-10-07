using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    public class CalcDuplex : ICalcDuplex
    {
        public void DivideNumbers(double a, double b)
        {
            var client = OperationContext.Current
                .GetCallbackChannel<ICalcCallback>();

            client.SendAnswer(a / b);
        }
    }
}
