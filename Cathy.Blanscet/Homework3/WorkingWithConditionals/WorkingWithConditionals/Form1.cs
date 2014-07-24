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
        int varMyNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeClicked(object sender, EventArgs e)
        {
            varMyNumber ++;
            if (varMyNumber > 10)
            {
                varMyNumber = 0;
                string varMessage = "Number too big!\nClick the button Click Me and watch what happens";
                IncrementLabel.Text = varMessage;
            }
            else
            {
                string varMessage =  "Click the button Click Me and watch what happens\n" + varMyNumber;
                IncrementLabel.Text = varMessage;
            }
        }
    }
}
