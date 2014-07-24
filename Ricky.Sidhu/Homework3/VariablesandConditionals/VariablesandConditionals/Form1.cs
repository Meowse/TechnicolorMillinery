using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesandConditionals
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

       

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter your first name");
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


