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
                        ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";

                        while (maxLoop < age)
                        {
                            while (cnt < maxCnt)
                            {
                                if (cnt == 3)
                                {
                                    ResultLabel.Text += "Happy Birthday, Dear " + varName + ". ";
                                }
                                else
                                {
                                    ResultLabel.Text += "Happy Birthday to you. ";
                                }
                                cnt++;
                            }
                            ResultLabel.Text += "\n"; //break between the versions
                            ResultLabel.ForeColor = Color.DarkTurquoise;
                            cnt = 1;
                            maxLoop ++;
                        }
                    }
                    else
                    {
                        TimeSpan varStartDt = new TimeSpan(12, 0, 0); //12 o'clock
                        TimeSpan varEndDt = new TimeSpan(17, 0, 0); //5 o'clock
                        TimeSpan varNowDt = DateTime.Now.TimeOfDay;
                        //MessageBox.Show("now is " + now);
                        //MessageBox.Show("end is " + end);

                        if ((varNowDt < varStartDt)) //before noon
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

                            ResultLabel.Text = ""; // clear the previous text
                            ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";

                            while (maxLoop < age)
                            {
                                while (cnt < maxCnt)
                                {
                                    if (cnt == 3)
                                    {
                                        ResultLabel.Text += "Good Morning, Dear " + varName + ". ";
                                    }
                                    else
                                    {
                                        ResultLabel.Text += "Good Morning to you. ";
                                    }
                                    cnt++;
                                }
                                ResultLabel.Text += "\n"; //break between the versions
                                ResultLabel.ForeColor = Color.MediumSeaGreen;
                                cnt = 1;
                                maxLoop++;
                            }
                        }

                        if ((varNowDt > varStartDt) && (varNowDt < varEndDt)) // between noon and 5 p.m.
                        {
                            ResultLabel.Text = ""; // clear the previous text
                            ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";
                            ResultLabel.Text += varSiestaTime;
                            ResultLabel.ForeColor = Color.MediumVioletRed;
                        }

                        if ((varNowDt > varEndDt)) // after 5 p.m.
                        {
                            ResultLabel.Text = ""; // clear the previous text
                            ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";
                            ResultLabel.Text =
                                "Twinkle, twinkle, little star,\nHow I wonder what you are!\nUp above the world so high,\nLike a diamond in the sky.\nTwinkle, twinkle, little star,\nHow I wonder what you are!";
                            ResultLabel.ForeColor = Color.MediumBlue;
                        }
                    }
                } //end of varGoodName > 0
            }
            else
            {
                MessageBox.Show("I cannot calculate your age.\nPlease reenter the year of your birth in yyyy format.");
            }
        }

        public static string ToBinary(Int64 Decimal)
        {
            // Declare a few variables we're going to need
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                BinaryHolder = Decimal%2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal/2;
            }

            // The algoritm gives us the binary number in reverse order (mirrored)
            // We store it in an array so that we can reverse it back to normal
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }
    }
}
