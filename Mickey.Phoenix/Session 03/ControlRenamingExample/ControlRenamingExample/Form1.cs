using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlRenamingExample
{
    public partial class Form1 : Form
    {
        int valueToDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void IncrementValue(object sender, EventArgs e)
        {
            valueToDisplay = valueToDisplay + 1;
            displayLabel.Text = valueToDisplay.ToString();
            if (valueToDisplay >= 10)
            {
                incrementButton.Enabled = false;
            }
        }

        private void ResetCounter(object sender, EventArgs e)
        {
            valueToDisplay = 0;
            displayLabel.Text = valueToDisplay.ToString();
            incrementButton.Enabled = true;
        }
    }
}
