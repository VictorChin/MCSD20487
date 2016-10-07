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
