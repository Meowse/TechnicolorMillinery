using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditionals
{
    public partial class Form1 : Form
    {
        int valueToDisplay;
        String greeting;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            valueToDisplay = valueToDisplay + 1;
            greetingsLabel.Text = valueToDisplay.ToString();
            if (valueToDisplay >= 10)
            {
                button1.Enabled = false;
                MessageBox.Show("Number is too big!!");
                valueToDisplay = 0;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String userName = nameField.Text;
            greetingsLabel.Text = greeting;
            if (userName == "Mickey")
            {
                greeting = "Hello, teacher!";
            }
            else
            {
                greeting = "Hello, " + userName;

            }
        }
    }

}

 
