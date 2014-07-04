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
        int MyNum = 0;
        int CondNum = 0;
        string Msg1 = "";
        string Msg2 = "";

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
            MyNum ++;
            Msg1 = MyNum + "\nClick the button Click Me and watch what happens";
            ClickMeLabel.Text = Msg1 = MyNum + "\nClick the button Click Me and watch what happens";
            ;
        }

        private void ConditionalTestButtonClicked(object sender, EventArgs e)
        {
            CondNum++;
            if (CondNum > 10)
            {
                CondNum = 0;
                Msg2 = CondNum + "\nClicked too many times - Reset to 0\nClick the button Test Me!";
                TestMeLabel.Text = Msg2;              
               
            }
            else
            {
                Msg2 = CondNum + "\nClick the button Test Me!";
                TestMeLabel.Text = Msg2;              
            }
            TestMeLabel.Text = Msg2;
        }
    }
}
