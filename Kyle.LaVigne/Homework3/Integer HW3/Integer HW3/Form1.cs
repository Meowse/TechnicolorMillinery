using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_HW3
{
    public partial class Form1 : Form
    {
        int valueToDisplay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            valueToDisplay = valueToDisplay ++;
            IntegerLabel.Text = valueToDisplay.ToString();

            if (valueToDisplay >= 10)
            {
                MessageBox.Show("Number too big!");
                valueToDisplay = 0;

            }
        }
    }
}


