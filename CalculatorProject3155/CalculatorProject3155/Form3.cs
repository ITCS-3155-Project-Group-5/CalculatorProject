using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
namespace CalculatorProject3155
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var client = new HttpClient();

            var values = new Dictionary<string, string>();
            values.Add("access_key", "0dd20b1e4b12728cd522eb516d840efd");

            var content = new FormUrlEncodedContent(values);

            var response = client.PostAsync("http://api.currencylayer.com/live?access_key=0dd20b1e4b12728cd522eb516d840efd", content);

            var responseString = response.Result;



        }
    }
}
