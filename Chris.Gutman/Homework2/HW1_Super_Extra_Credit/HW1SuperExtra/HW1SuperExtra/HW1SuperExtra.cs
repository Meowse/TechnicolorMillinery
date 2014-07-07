using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1SuperExtra
{
    public partial class SuperExtraCreditForm : Form
    {
        public SuperExtraCreditForm()
        {
            InitializeComponent();
           
        }

 
        private void SuperExtraCreditForm_Load(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();          
        }

        private void brushbutton_click(object sender, EventArgs e)
        {
            MessageBox.Show("Tooth Brushing Instructions:\n1. Get Toothbrush\n"+
                "2. Get Toothpaste\n"+
                "3. Yada yada yada");
        }

        private void helloButton_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!");
        }
    }
}
