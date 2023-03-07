using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetInfo
{
    public partial class Boredcs : Form
    {
        public Boredcs()
        {
            InitializeComponent();
        }

        const string ApiUrl = "https://www.boredapi.com/api/activity";

        private async void btn_GetActivity_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync(ApiUrl);

            var activity = JsonConvert.DeserializeObject<Bored>(result);

            tbx_type.Text = activity.type;
            rtb_activity.Text = activity.activity;

        }

        public class Bored
        {
            public string? activity { get; set; }
            public string? type { get; set; }                
            public float participants { get; set; }                
            public float price { get; set; }
            public string? link { get; set; }
            public long key { get; set; }
            public float accessibility { get; set; }
        }
    }
}
