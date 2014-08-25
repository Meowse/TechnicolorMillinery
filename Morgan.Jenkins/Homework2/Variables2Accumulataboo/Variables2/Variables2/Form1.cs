using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int bucket = 0;

        private void addone(object sender, EventArgs e)
        {
            bucket += 1;
            if (bucket <= 10)
            {
                string inbucket = bucket.ToString();
                showbucket.Text = inbucket;
            }
            else
            {
                showbucket.Text = "Too much in bucket!";
            }

        }

        public void dumpbucket(object sender, EventArgs e)
        {
            bucket = 0;
            string inbucket = bucket.ToString();
            showbucket.Text = inbucket;
        }
    }
}
