using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorBrain;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Calculator _calculator = new Calculator();

        private RegexOptions reoptions = new RegexOptions();


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('1');
        }

        private void Button2_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('2');
        }

        private void Button3_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('3');
        }

        private void Button4_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('4');
        }

        private void Button5_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('5');
        }

        private void Button6_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('6');
        }

        private void Button7_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('7');
        }

        private void Button8_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('8');
        }

        private void Button9_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('9');
        }

        private void Button0_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('0');
        }



        private void Point_click(object sender, EventArgs e)
        {
            const string mystring = @".+\..+";
            reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
            var re = new Regex(mystring);
            var rematch = re.Match(mystring);

            if (rematch.Length >= 1)
            {
                
            }
            else
            {
                _calculator.ProvideInput('.');
            }
        }
    }
   
}
