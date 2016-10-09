using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07_ServiceBusRelay_Basic_HostServer
{
    class ProblemSolver : IProblemSolver
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
