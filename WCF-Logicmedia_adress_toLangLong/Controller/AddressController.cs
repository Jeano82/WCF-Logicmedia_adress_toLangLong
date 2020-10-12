using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Logicmedia_adress_toLangLong.Model;
using WCF_Logicmedia_adress_toLangLong.DataAssLayer;
using System.ServiceModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace WCF_Logicmedia_adress_toLangLong.Controller {
    class AddressController {
        public DBaddress DBA = new DBaddress();

        public AddressController() {
        
        }

        public IEnumerable<Address> GetAddresses(){
            

            return DBA.GetAddresses();
        }

        public async Task<Lat_Long_Model> CallAPI() {
            string KEY = "";
            using (var client = new HttpClient()) {
                List<Address> ad = (List<Address>)GetAddresses();
                string address1 = "Nøddelunden 38";
                string zip = "5580";

                string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address1 + "," + zip + "&key=" + KEY;
                string url2 = "https://xkcd.com/info.0.json";

                //foreach (var item in ad) {

                //    client.BaseAddress = new Uri("https://maps.googleapis.com/maps/api/geocode/json?address=" + item.AddressName + "," + item.zipcode + "&key=YOUR_API_KEY" + KEY);

                //    HttpResponseMessage httpResponse = await client.GetAsync(url);
                //}
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                using ( HttpResponseMessage httpResponse = await client.GetAsync(url)) {

                    if (httpResponse.IsSuccessStatusCode) {

                        Lat_Long_Model LLM = await httpResponse.Content.ReadAsAsync<Lat_Long_Model>();
                      
                        return LLM;
                    }
                    else {

                        throw new Exception(httpResponse.ReasonPhrase);
                    }
                }
            }
        }


        public async Task<OpenAPI> CallOpenGeo() {

            string OpenKey = "";
            using (var client = new HttpClient()) {
                List<Address> ad = (List<Address>)GetAddresses();
                string address1 = "Nøddelunden 38";
                string zip = "5580";

                string url = "http://www.mapquestapi.com/geocoding/v1/address?key="+OpenKey +"+&location="+address1+","+zip;


                //foreach (var item in ad) {

                //    client.BaseAddress = new Uri("https://maps.googleapis.com/maps/api/geocode/json?address=" + item.AddressName + "," + item.zipcode + "&key=YOUR_API_KEY" + KEY);

                //    HttpResponseMessage httpResponse = await client.GetAsync(url);
                //}
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                using (HttpResponseMessage httpResponse = await client.GetAsync(url)) {

                    if (httpResponse.IsSuccessStatusCode) {

                        OpenAPI LLM = await httpResponse.Content.ReadAsAsync<OpenAPI>();

                        return LLM;
                    }
                    else {

                        throw new Exception(httpResponse.ReasonPhrase);
                    }
                }
            }


        }

        public void StreamAPI() {
            string KEY = "AIzaSyCTfCEHNq6KlRunHFkg_boDvsoKrwhKXL8";
            string address1 = "Nøddelunden%2038";
            string zip = "5580";

            string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address1 + "," + zip + "&key=" + KEY;

            string Sresult = String.Format(url);
            WebRequest request = WebRequest.Create(Sresult);
            HttpWebResponse WebRes = null;
            
        
        }
    }
}
