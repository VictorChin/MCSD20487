using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Firebrand
{
    [DataContract]
    public class Numbers
    {
        [DataMember]
        public double A { get; set; }
        [DataMember]
        public double B { get; set; }
    }
}
