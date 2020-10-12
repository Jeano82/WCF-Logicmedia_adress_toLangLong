using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WCF_Logicmedia_adress_toLangLong.Model;

namespace WCF_Logicmedia_adress_toLangLong.DataAssLayer {
    class DBaddress {
        private string _connectionString;
        List<Address> addresses;
        public DBaddress() {
            _connectionString = DB.DbConnectionString;
        }

        public IEnumerable<Address> GetAddresses() {
            Address address = new Address();
            addresses = new List<Address>();
            using (SqlConnection connection = new SqlConnection(_connectionString)) {

                connection.Open();
                for (int i = 0; i <= 100; i += 100) {
                    

                    using (SqlCommand CmdGetCompany = connection.CreateCommand()) {
                        try {



                            CmdGetCompany.CommandText = " SELECT DISTINCT Adresse1, PostNr FROM Addresse_with_people_age_sorted ORDER BY PostNr " +
                                "OFFSET " + i + " ROWS FETCH NEXT 100 ROWS ONLY";


                            SqlDataReader reader = CmdGetCompany.ExecuteReader();
                            while (reader.Read()) {
                                address.AddressName = reader.GetString(reader.GetOrdinal("Adresse1"));
                                address.zipcode = reader.GetString(reader.GetOrdinal("PostNr"));

                                addresses.Add(address);

                            }
                            reader.Close();
                        }

                        catch (SqlException e) {

                            return null;
                        }
                    }
                }
                 return  addresses;
                
            }
        }


    }
}
