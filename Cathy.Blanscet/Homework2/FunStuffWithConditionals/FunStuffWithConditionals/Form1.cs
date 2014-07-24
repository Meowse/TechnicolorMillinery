using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunStuffWithConditionals
{
    public partial class Form1 : Form
    {
        string msgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void GoButtonClicked(object sender, EventArgs e)
        {
            var myYr = YearTextBox.Text;
            int yrTest;
            bool res = int.TryParse(myYr, out yrTest);

            // check for length
            if (myYr.Length > 4)
            {
                //MessageBox.Show("The year is too long");
                msgStr = "The year is too long";
            }
            else
            {
                if (myYr.Length < 4)
                {
                    //MessageBox.Show("The year is too short");
                    msgStr = "The year is too short";
                }
            }

            // check for alphas
            if (res)
            {
                //MessageBox.Show("is numeric");
                if (msgStr == "")
                {
                    //msgStr = "is numeric";
                }
                else
                {
                    msgStr = msgStr + "\nis numeric";
                }
                
            }
            else
            {
                //MessageBox.Show("not numeric");
                if (msgStr == "")
                {
                    msgStr = "is not numeric";
                }
                else
                {
                    msgStr = msgStr + "\nis not numeric";
                }
            }

            // passed length and alpha checks should be ok
            if (msgStr.Length == 0)
            {
                int xYr = Convert.ToInt32(myYr);
                if ((xYr % 4) == 0)
                {
                    if ((xYr%100) == 0)
                    {
                        if ((xYr%400) == 0)
                        {
                            msgStr = "That year is a Leap Year";
                            //MessageBox.Show(msgStr);
                        }
                        else
                        {
                             msgStr = "That year is not a Leap Year";
                            //MessageBox.Show(msgStr);
                        }
                    }
                    else
                    {
                        msgStr = "That year is a Leap Year";
                        //MessageBox.Show(msgStr);
                        }
                }
                else
                    {
                    msgStr = "That year is not a Leap Year";
                    //MessageBox.Show(msgStr);
                    }
            }
            /*else
            {
                MessageBox.Show(msgStr);
            }*/
            MessageBox.Show(msgStr);
            YearTextBox.Text = "";
            msgStr = "";
        }
    }
}
