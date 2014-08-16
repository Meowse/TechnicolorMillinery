using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private string buttonZero_Click(object sender, EventArgs e)
        {
            return DisplayResults.text = "0";
        }

        private void DisplayResults_TextChanged(object sender, EventArgs e)
        {
            // not used
        }
    }
}
