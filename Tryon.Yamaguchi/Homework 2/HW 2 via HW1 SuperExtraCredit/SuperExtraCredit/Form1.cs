using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperExtraCredit
{
    public partial class SuperExtraCredit : Form
    {
        public SuperExtraCredit()
        {
            InitializeComponent();
            //The Label steps is not visible when initialized
            lblSteps.Visible = false;
        }

        private void displayMessage_Click(object sender, EventArgs e)
        {
            //Button makes the label Steps visible
            lblSteps.Visible = true;
        }
    }
}
