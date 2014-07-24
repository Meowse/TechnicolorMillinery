using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2ExtraCredit
{
    public partial class Form1 : Form 
    {

        public Form1()
        {
            InitializeComponent();
            txtInput.Focus();
            lblIntegerValue.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Visible = false;

            if (txtInput.Text.Trim().Length == 0 || txtInput.Text == null)
            {
                MessageBox.Show("You must enter text to proceed");
            }// End if
            else
            {
                Greeting aGreeting = new Greeting(txtInput.Text);
                lblOutput.Text = "Hello, " + aGreeting.greeting;
                lblOutput.Visible = true;
            }//End else
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Integer anInteger = new Integer();
            if(anInteger.aNum > 10){
                MessageBox.Show("Number too big!");
                anInteger.setInteger();
            }

            lblIntegerValue.Text = anInteger.aNum.ToString();
            lblIntegerValue.Visible = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
