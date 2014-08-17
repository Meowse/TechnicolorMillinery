using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greet_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetThem(object sender, EventArgs e)
        {
            String userName = nameField.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("Please enter your name, so I can greet you porperly!");
            }
            else
            {
                
            }
            String greeting = "Hello, " + userName;
            greetsLable.Text = greeting;
            }

        private void greetsLable_Click(object sender, EventArgs e)
        {

        }

    }
}
