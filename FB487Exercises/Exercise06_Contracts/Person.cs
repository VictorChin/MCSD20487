using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    [DataContract(Namespace = "http://www.firebrandtraining.com/exercise06/2016/05/")]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
