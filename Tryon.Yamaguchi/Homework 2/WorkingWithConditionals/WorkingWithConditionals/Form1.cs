using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithConditionals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;

            string strConvertNumber = txtNumber.Text;

            int intEnteredNumber = 0;

            intEnteredNumber = Convert.ToInt32(strConvertNumber);
           

            if (string.Equals(strName, "Mickey", StringComparison.OrdinalIgnoreCase))
            {
                lblGreeting.Text = "Hello, Teacher!";
            }
            else
            {
                lblGreeting.Text = "Hello, " + strName;
            }

            if (intEnteredNumber > 10)
            {

                MessageBox.Show("Number too big!\n"+ "Resetting to zero!");

                txtNumber.Text = "0";

            }
            else
            {
                lblFinalNumber.Text = intEnteredNumber.ToString();
            }
        
        }
    }
}
