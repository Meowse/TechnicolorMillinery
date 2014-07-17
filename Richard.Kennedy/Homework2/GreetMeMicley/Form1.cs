using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetMeMicley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Check if a name was entered
                if (textBox1.Text == "")
                {
                    // Clear prior name
                    label2.Text = "";
                    // Give warning
                    MessageBox.Show("Please enter your first name.");
                }
                else
                {
                    if (textBox1.Text == "Mickey")
                    {
                        label2.Text = "Hello, Teacher!";
                    }
                    else
                    {
                        label2.Text = "Hello, " + textBox1.Text;
                    }
                }

            }
        }
    }
}
