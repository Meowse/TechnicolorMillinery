using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EnterName.Text == "")
            {
                // do not print anything
                labelForName.Text = "";
                // display a warning for them to add a name
                Warninglabel.Text = "Please enter your name, above.";
            }
            else
            {
                labelForName.Text = "Hello " + EnterName.Text;
                // Remove the warning since they did what we wanted
                Warninglabel.Text = "";
            }
            
        }
    }
}
