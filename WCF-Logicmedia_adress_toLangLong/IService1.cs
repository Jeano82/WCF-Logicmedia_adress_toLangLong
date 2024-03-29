﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_Logicmedia_adress_toLangLong.Model;

namespace WCF_Logicmedia_adress_toLangLong {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
     interface IService1 {
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        IEnumerable<Address> GetAddresses();
        // TODO: Add your service operations here
        [OperationContract]
        Task<OpenAPI> CallOpenGeo();

        [OperationContract]
        Task<Lat_Long_Model> Callapi();

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCF_Logicmedia_adress_toLangLong.ContractType".
    //[DataContract]
    //public class CompositeType {
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue {
    //        get
    //        {
    //            return boolValue;
    //        }
    //        set
    //        {
    //            boolValue = value;
    //        }
    //    }

    //    [DataMember]
    //    public string StringValue {
    //        get
    //        {
    //            return stringValue;
    //        }
    //        set
    //        {
    //            stringValue = value;
    //        }
    //    }
    //}
}
