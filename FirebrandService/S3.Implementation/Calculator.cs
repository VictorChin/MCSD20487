using System;
using System.Security.Permissions;
using System.ServiceModel;
namespace Firebrand
{
    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.Single, 
        ConcurrencyMode = ConcurrencyMode.Multiple)]

    public class Calculator : ICalculator
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Sales")]
        //[PrincipalPermission(SecurityAction.Deny, Role = "HR")]
        public double Add(double a, double b)
        {
            if (a > 10)
            {
                System.Threading.Thread.Sleep(4000);
            }
            if ((a == 13) || (b == 13))
            {
                //throw new ArgumentException("13 is unlucky!");
                var addfault = new AddFault
                {
                    BankAccountNumber = 123456,
                    Description = "13 is unlucky!",
                    ErrorLevel = 42,
                    Stuff = new string[] { "Alice", "Bob" }
                };
                throw new FaultException<AddFault>(addfault,
                    new FaultReason("This is a custom fault message."));
            }
            return a + b;
        }

        public double Multiply(Numbers n)
        {
            return n.A * n.B;
        }
    }
}
