using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_part_1b
{
    public partial class Form1 : Form
    {
        int valueToDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueToDisplay = valueToDisplay + 1;
            label1.Text = valueToDisplay.ToString();
            
        }
    }
}
