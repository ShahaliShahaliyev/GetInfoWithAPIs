using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cats_Click(object sender, EventArgs e)
        {
            Cats cats = new Cats();
            cats.ShowDialog();
        }

        private void btn_bored_Click(object sender, EventArgs e)
        {
            Boredcs boredcs = new Boredcs();
            boredcs.ShowDialog();
        }

        private void btn_joke_Click(object sender, EventArgs e)
        {
            Joke joke = new Joke();
            joke.ShowDialog();
        }
    }
}
