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
    public partial class Joke : Form
    {
        public Joke()
        {
            InitializeComponent();
        }

        const string ApiUrl = "https://official-joke-api.appspot.com/random_joke";

        private async void btn_search_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync(ApiUrl);
            var joke = JsonConvert.DeserializeObject<Jokes>(result);

            tbx_type.Text = joke.type;
            rtb_jokeSetub.Text = joke.setup;
            rtb_punchline.Text = joke.punchline;
        }

        private void rtb_jokeSetub_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Jokes
    {
        public string? type { get; set; }
        public string? setup { get; set; }
        public string? punchline { get; set; }
        public int Id { get; set; }
    }
}
