using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace CalculatorProject3155
{
    public partial class Form3 : Form
    {
        public class Conversions
        {

        }
        public Form3()
        {
            InitializeComponent();
            /*string ACCESS_KEY = "0dd20b1e4b12728cd522eb516d840efd";
            string baseURL = "http://api.currencylayer.com/";
            string ENDPOINT = "live"; 
            */

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.currencylayer.com/live?access_key=0dd20b1e4b12728cd522eb516d840efd");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();

            string result = GetResponseBody(response);

            JArray json = (JArray)result;

            JArray objects = JArray.Parse(json.ToString()); // parse as array  
            foreach (JObject root in objects)
            {
                foreach (KeyValuePair<String, JToken> app in root)
                {
                    var appName = app.Key;
                    var description = (String)app.Value["Description"];
                    var value = (String)app.Value["Value"];

                    Console.WriteLine(appName);
                    Console.WriteLine(description);
                    Console.WriteLine(value);
                    Console.WriteLine("\n");
                }
            }
        }


        public static String GetResponseBody(HttpWebResponse response)
        {
            Stream responseStream = response.GetResponseStream();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStreamReader = new StreamReader(responseStream, enc);
            return responseStreamReader.ReadToEnd();
        }

    }

 }

