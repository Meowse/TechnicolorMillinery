using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add1toInteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert label text to integer
            int Sum = Convert.ToInt32(label1.Text);
            // Increment integer by 1
            Sum = Sum++;

            //Display the results in the label
            label1.Text = Convert.ToString(Sum);
        }
    }
}