using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBdaySDExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeClicked(object sender, EventArgs e)
        {
            string varName = NameTextBox.Text;
            int varGoodName = 0;

            string varBDate = BDayBox.Text;
            string varSysDate = DateTime.Now.ToString("M/d/yyyy");

            // for part b of Extra Credit
            int varCurrentYear = DateTime.Now.Year;
            var varBirthYear = BirthYearTextBox.Text;
            int BirthYr;
            bool varIsGoodYear = int.TryParse(varBirthYear, out BirthYr);

            if (varIsGoodYear)
            {
                int age = (varCurrentYear - BirthYr);
                
                /*string varBDline1 = "Happy Birthday to you.";
                string varBDline2 = "Happy Birthday, Dear ";
                string varGMline1 = "Good Morning to you.";
                string varGMline2 = "Good Morning, Dear ";*/

                string varSiestaTime = "We're sorry but it is siesta time between noon and 5 pm.";

                if (varName == "")
                {
                    MessageBox.Show("I didn't catch your name.\nPlease enter your name.");
                }
                else
                {
                    varGoodName = 1;
                }

                if (varGoodName > 0)
                {
                    if (DateTime.Parse(varBDate) == DateTime.Parse(varSysDate))
                    {
                        // replace this with a while loop
                        //ResultLabel.Text = varBDline1 + "\n" + varBDline1 + "\n" + varBDline2 + varName + ",\n" + varBDline1;
                        int cnt = 1;
                        int maxCnt = 5;
                        int maxLoop = 0;
                        if (age == 0)
                        {
                            age = 1;
                        }

                        ResultLabel.Text = ""; // clear the previous text
                        while (maxLoop < age)
                        {
                            while (cnt < maxCnt)
                            {
                                if (cnt == 3)
                                {
                                    ResultLabel.Text += "Happy Birthday, Dear " + varName + ",\n";
                                }
                                else
                                {
                                    ResultLabel.Text += "Happy Birthday to you.\n";
                                }
                                cnt++;
                            } 
                            ResultLabel.Text += "\n";   //break between the versions
                            cnt = 1;
                            maxLoop ++;
                        } 
                    }
                    else
                    {
                        TimeSpan start = new TimeSpan(12, 0, 0); //12 o'clock
                        TimeSpan end = new TimeSpan(17, 0, 0); //5 o'clock
                        TimeSpan now = DateTime.Now.TimeOfDay;
                        //MessageBox.Show("now is " + now);
                        //MessageBox.Show("end is " + end);

                        if ((now < start)) //before noon
                        {
                            //replace with a while loop
                            //ResultLabel.Text = varGMline1 + "\n" + varGMline1 + "\n" + varGMline2 + varName + ",\n" + varGMline1;
                            int cnt = 1;
                            int maxCnt = 5;
                            int maxLoop = 0;
                            if (age == 0)
                            {
                                age = 1;
                            }

                            ResultLabel.Text = "";
                            while (maxLoop < age)
                            {
                                while (cnt < maxCnt)
                                {
                                    if (cnt == 3)
                                    {
                                        ResultLabel.Text += "Good Morning, Dear " + varName + ",\n";
                                    }
                                    else
                                    {
                                        ResultLabel.Text += "Good Morning to you.\n";
                                    }
                                    cnt++;
                                }
                                ResultLabel.Text += "\n";   //break between the versions
                                cnt = 1;
                                maxLoop++;
                            }
                        }

                        if ((now > start) && (now < end)) // between noon and 5 p.m.
                        {
                            ResultLabel.Text = varSiestaTime;
                        }

                        if ((now > end)) // after 5 p.m.
                        {
                            ResultLabel.Text =
                                "Twinkle, twinkle, little star,\nHow I wonder what you are!\nUp above the world so high,\nLike a diamond in the sky.\nTwinkle, twinkle, little star,\nHow I wonder what you are!";
                        }
                    }
                } //end of varGoodName > 0
            }
            else
            {
                MessageBox.Show("I cannot calculate your age.\nPlease reenter the year of your birth in yyyy format.");
            }
        }
    }
}
