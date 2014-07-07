using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_WorkingWithVariables
{   
    public partial class Form1 : Form
    {
        int varMyNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetMeButtonClicked(object sender, EventArgs e)
        {
             string varName = NameTextBox.Text;
            MessageBox.Show("Hello " + varName);

        }

        private void IncrementNumberButtonClicked(object sender, EventArgs e)
        {
            varMyNumber ++;
            string varMessage = varMyNumber + "\nClick the button Click Me and watch what happens";
            ClickMeLabel.Text = varMessage;
        }
    }
}
