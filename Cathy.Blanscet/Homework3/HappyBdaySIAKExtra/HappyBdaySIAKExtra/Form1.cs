using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HappyBdaySIAKExtra
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
            TimeSpan varStartDt = new TimeSpan(12, 0, 0); //12 o'clock
            TimeSpan varEndDt = new TimeSpan(17, 0, 0); //5 o'clock
            TimeSpan varNowDt = DateTime.Now.TimeOfDay;
            //TimeSpan varNowDt = new TimeSpan(9, 0, 0); // for testing purposes only uncomment when needed.

            // give age a non zero value if it is zero.
            if (age == 0)
            {
                age = 1;
            }

            string varSiestaTime = "We're sorry but it is siesta time between noon and 5 pm.";
            string varBDWords = "Happy Birthday";
            string varGMWords = "Good Morning";

            if (varName == "")
            {
                ResultLabel.Text = "I didn't catch your name.\nPlease enter your name.";
            }
            else
            {
                ResultLabel.Text = ""; // clear the previous text
                ResultLabel.Text = "Your age in Binary is: " + GetBinaryValueForAge(age) + "!!!\n";
                //ResultLabel.Text = "Your age in Binary is: " + ToBinary(age) + "!!!\n";

                if (varCurrentMonth == varBirthMonth && varCurrentDay == varBirthDay)
                {
                    ResultLabel.Text += SingSong(age, varName, varBDWords);
                    ResultLabel.ForeColor = Color.DarkTurquoise;
                }
                else
                {
                    if ((varNowDt < varStartDt)) //before noon
                    {
                        ResultLabel.Text += SingSong(age, varName, varGMWords);
                        ResultLabel.ForeColor = Color.MediumSeaGreen;
                    }

                    if ((varNowDt > varStartDt) && (varNowDt < varEndDt)) // between noon and 5 p.m.
                    {
                        ResultLabel.Text += varSiestaTime;
                        ResultLabel.ForeColor = Color.MediumVioletRed;
                    }

                    if ((varNowDt > varEndDt)) // after 5 p.m.
                    {
                        ResultLabel.Text +=
                            "Twinkle, twinkle, little star,\nHow I wonder what you are!\nUp above the world so high,\nLike a diamond in the sky.\nTwinkle, twinkle, little star,\nHow I wonder what you are!";
                        ResultLabel.ForeColor = Color.MediumBlue;
                    }
                } // end of birthday check
            } //end of varGoodName check
        }

        public static string SingSong(int age, string varName, string varWords)
        {
            int cnt = 1;
            int maxCnt = 5;
            int maxLoop = 0;
            string varStr = "";

            while (maxLoop < age)
            {
                while (cnt < maxCnt)
                {
                    if (cnt == 3)
                    {
                        varStr += varWords + ", Dear " + varName + ". ";
                    }
                    else
                    {
                        varStr += varWords + " to you. ";
                    }
                    cnt++;
                }
                varStr += "\n"; //break between the versions
                cnt = 1;
                maxLoop++;
            }
            return varStr;
        }

        public static string GetBinaryValueForAge(int varDecimal)
        {
            if (varDecimal == 0)
            {
                return "0";
            }
            int biggestPowerOf2 = GetBiggestPowerOf2(varDecimal);
            return turnItBinary(varDecimal, biggestPowerOf2);
        }

        public static int GetBiggestPowerOf2(int varDecimal)
        {
            int varPowerOf2 = 1;
            while (varPowerOf2 <= varDecimal)
            {
                varPowerOf2 = varPowerOf2*2;
            }
            return varPowerOf2/2;
        }

        public static string turnItBinary(int varDecimal, int varPowerOf2)
        {
            string binaryValue = "";

            while (varPowerOf2 > 0)
            {
                if (varDecimal >= varPowerOf2)
                {
                    binaryValue = binaryValue + "1";
                    varDecimal = varDecimal - varPowerOf2;
                }
                else
                {
                    binaryValue = binaryValue + "0";
                }
                varPowerOf2 = varPowerOf2/2;
            }

            return binaryValue;
        }

/*
         // this worked but couldn't do a helper method as it was pretty simple but did things backwards
        public static string ToBinary(Int64 Decimal)
        {
            // Declare a few variables we're going to need
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal / 2;
            }

            // The algoritm gives us the binary number in reverse order (mirrored)
            // We store it in an array so that we can reverse it back to normal
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }
 */
    }
}
