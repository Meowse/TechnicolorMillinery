using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithVaraiables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetMeClick(object sender, EventArgs e)
        {
            string varName = TextBoxForName.Text;
            if (varName == "")
            {
                ResultLabel.Text = "You didn't give me your name.\nPlease enter your name.";
            }
            else
            {

                if (varName == "Mickey")
                {
                    ResultLabel.Text = "Hello teacher!";
                }
                else
                {
                    ResultLabel.Text = "Hello " + varName;
                }
                
            }
        }
    }
}
