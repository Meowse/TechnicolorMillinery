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

            // for part b of Extra Credit
            int varCurrentMonth = DateTime.Now.Month;
            int varCurrentDay = DateTime.Now.Day;
            int varCurrentYear = DateTime.Now.Year;
            int varBirthMonth = BDayBox.Value.Month;
            int varBirthDay = BDayBox.Value.Day;
            int varBirthYr = BDayBox.Value.Year;
            int age = (varCurrentYear - varBirthYr);
            if (age == 0)
            {
                age = 1;
            }

            string varSiestaTime = "We're sorry but it is siesta time between noon and 5 pm.";

            if (varName == "")
            {
                ResultLabel.Text = "I didn't catch your name.\nPlease enter your name.";
            }
            else
            {
                ResultLabel.Text = ""; // clear the previous text
                ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";

                if (varCurrentMonth == varBirthMonth && varCurrentDay == varBirthDay)
                {
                    int cnt = 1;
                    int maxCnt = 5;
                    int maxLoop = 0;

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

                    if ((varNowDt < varStartDt)) //before noon
                    {
                        int cnt = 1;
                        int maxCnt = 5;
                        int maxLoop = 0;

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
                        ResultLabel.Text += varSiestaTime;
                        ResultLabel.ForeColor = Color.MediumVioletRed;
                    }

                    if ((varNowDt > varEndDt)) // after 5 p.m.
                    {
                        ResultLabel.Text =
                            "Twinkle, twinkle, little star,\nHow I wonder what you are!\nUp above the world so high,\nLike a diamond in the sky.\nTwinkle, twinkle, little star,\nHow I wonder what you are!";
                        ResultLabel.ForeColor = Color.MediumBlue;
                    }
                }
            } //end of varGoodName ==""
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
