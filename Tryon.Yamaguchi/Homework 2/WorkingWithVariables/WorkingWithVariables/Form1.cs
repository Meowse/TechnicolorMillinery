using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithVariables
{
    public partial class frmWorkingWithVariables : Form
    {
        public frmWorkingWithVariables()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            //Button will combine the user name from the text box and a greeting and display it he display greet label
            lblGreetingMessage.Text= "Hello, " + txtName.Text + "!";
        }
    }
}
