using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraCreditPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add 1 to whatever is there
            int AddMe = Convert.ToInt32(ResultsLabel.Text);
            AddMe = AddMe + 1;

            if (AddMe > 10)
            {
                AddMe = 0;
                WarningLabel.Text = "That's too high, you have been zero'd!";
            } else {
                // no warning needed
                WarningLabel.Text = "";
            }

            //Display the results in the label
            ResultsLabel.Text = Convert.ToString(AddMe);
        }
    }
}
