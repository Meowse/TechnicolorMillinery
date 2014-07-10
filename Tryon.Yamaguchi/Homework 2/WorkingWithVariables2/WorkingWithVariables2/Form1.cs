using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithVariables2
{
    public partial class frmWorkingWithVariables2 : Form
    {
        public int MyVariable = 12;

        public frmWorkingWithVariables2()
        {
            InitializeComponent();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            MyVariable = MyVariable + 1;
            lblNumberDisplay.Text = MyVariable.ToString();


        }
    }
}
