using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2_EC_Part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetButtonClick(object sender, EventArgs e)
        {
            String UserName = nameField.Text;
            if (UserName.Length == 0)
            {
                MessageBox.Show("Oops, please enter your name above.");
            }
            else
            {
                String Greeting = "Hello, " + UserName;

                GreetingLabel.Text = Greeting;

            }
        }
    }
}

