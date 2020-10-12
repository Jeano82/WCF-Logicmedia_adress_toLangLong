namespace WCF_Logicmedia_adress_toLangLong.Model {
    public class Result {
        public Address_Components[] address_components {
            get; set;
        }
        public string formatted_address {
            get; set;
        }
        public Geometry geometry {
            get; set;
        }        
    }

   
    }
