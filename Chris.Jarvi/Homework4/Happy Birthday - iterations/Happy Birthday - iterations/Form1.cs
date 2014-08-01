using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Birthday___iterations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greet(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime birthDate = dtBirthdate.Value;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Hello, {0}", txtName.Text));
            sb.AppendLine();
            if (birthDate.Month == today.Month && birthDate.Day == today.Day)
            {
                for (int i = 1; i <= 4; i++ )
                {
                    if ( i % 3 == 0)
                    {
                        sb.AppendLine(String.Format("Happy birthday, dear {0}", txtName.Text));
                    }
                    else
                    {
                        sb.AppendLine("Happy birthday to you");
                    }
                }
                    lblOutput.Text = sb.ToString();
            }
            else
            {
                if (today.Hour < 12)
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        sb.AppendLine("Good morning, good morning, good morning to you");
                    }
                    sb.AppendLine("Our day is beginning, there's so much to do");
                    sb.AppendLine("So, good morning, good morning, good morning to you");
                        lblOutput.Text = sb.ToString();
                }
                else if (today.Hour < 17)
                {
                    lblOutput.Text = String.Format("Sorry {0}, I'm taking a siesta", txtName.Text);
                }
                else
                {
                    sb.AppendLine("Rock-a-bye baby, in the treetop");
                    sb.AppendLine("When the wind blows, the cradle will rock");
                    sb.AppendLine("When the bough breaks, the cradle will fall");
                    sb.AppendLine("And down will come baby, cradle and all");
                    lblOutput.Text = sb.ToString();
                }
            }
        }
    }
}
