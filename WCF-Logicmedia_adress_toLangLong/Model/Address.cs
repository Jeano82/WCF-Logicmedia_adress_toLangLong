using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Logicmedia_adress_toLangLong.Model {
    [DataContract]
    public class Address {

        [DataMember]
        public string AddressName {
            get; set;
        }

        [DataMember]
        public string zipcode {
            get; set;
        }

        [DataMember]
        public string lang {
            get; set;
        }

        [DataMember]
        public string Long {
            get; set;
        }   


    }
}
