using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GetInfo
{
    public partial class Cats : Form
    {
        public Cats()
        {
            InitializeComponent();
        }
        const string apiUrl = "https://catfact.ninja/fact";

        private async void btn_search_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(apiUrl);

            var catFact = JsonConvert.DeserializeObject<CatFact>(result);

            rtb_catFact.Text = catFact.Fact;
        }

        private void Cats_Load(object sender, EventArgs e)
        {

        }
    }

    public class CatFact
    {
        public string? Fact { get; set; }
        public int Length { get; set; }
    }
}
