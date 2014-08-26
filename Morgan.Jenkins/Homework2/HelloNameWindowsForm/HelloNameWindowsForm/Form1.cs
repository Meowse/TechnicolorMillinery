using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloNameWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickedOk(object sender, EventArgs e)
        {          
            if(namefield.Text == "Mickey" || namefield.Text == "mickey")           
            {                         
                greetinglabel.Text = "Hello, Teacher!";
            }
            else
            {
                 string name = namefield.Text;
                 greetinglabel.Text = "Hello, " + name;
            }
        }
    }
}
