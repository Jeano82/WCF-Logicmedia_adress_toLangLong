using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Logicmedia_adress_toLangLong.DataAssLayer {
    class DB {

        public static string DbConnectionString {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectMsSqlString"].ToString();
            }

        }
    }
}
