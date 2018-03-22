using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    [DataContract]
    public class Station
    {
        [DataMember]
        internal string city { get; set; }

        [DataMember]
        internal string name { get; set; }

        [DataMember]
        internal string address { get; set; }

        [DataMember]
        internal int availableBikes { get; set; }

        [DataMember]
        internal double latitude { get; set; }

        [DataMember]
        internal double longitude { get; set; }
    }
}
