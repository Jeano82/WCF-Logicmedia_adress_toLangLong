using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_Logicmedia_adress_toLangLong.Controller;
using WCF_Logicmedia_adress_toLangLong.Model;

namespace WCF_Logicmedia_adress_toLangLong {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1 {

        AddressController AC = new AddressController();

        public System.Threading.Tasks.Task<Lat_Long_Model> Callapi() {
           return AC.CallAPI();
        }

        public Task<OpenAPI> CallOpenGeo() {
            return AC.CallOpenGeo();
        }

        public IEnumerable<Address> GetAddresses() {
            return (List<Address>) AC.GetAddresses();
        }
    }
}

