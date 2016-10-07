using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    [DataContract]
    public class AddFault
    {
        [DataMember]
        public int ErrorLevel { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int BankAccountNumber { get; set; }
        [DataMember]
        public string[] Stuff { get; set; }
    }
}
