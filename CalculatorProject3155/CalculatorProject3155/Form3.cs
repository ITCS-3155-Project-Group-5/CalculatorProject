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
using System.Web.UI;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace CalculatorProject3155
{
    public partial class Form3 : Form
    {

        public class Conversions
        {
            public Boolean success { get; set; }
            public string terms { get; set; }
            public string privacy { get; set; }
            public double timestamp { get; set; }
            public string source { get; set; }
            public Dictionary<string, double> quotes { get; set; }

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

            string json = GetResponseBody(response);

            Conversions conversions = JsonConvert.DeserializeObject<Conversions>(json);
        }


        public static String GetResponseBody(HttpWebResponse response)
        {
            Stream responseStream = response.GetResponseStream();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStreamReader = new StreamReader(responseStream, enc);
            return responseStreamReader.ReadToEnd();
        }

        private void USDConversionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = USDConversionList.SelectedItem.ToString();
        }
    }

 }

