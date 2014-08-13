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


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Calculator _calculator = new Calculator();




        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('1');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button2_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('2');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button3_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('3');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button4_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('4');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button5_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('5');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button6_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('6');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button7_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('7');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button8_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('8');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button9_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('9');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button0_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('0');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Point_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('.');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Plus_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('+');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Minus_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('-');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Divide_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('/');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Times_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('*');
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Clear_click(object sender, EventArgs e)
        {
            _calculator.ProvideInput('c');
            Displaybox.Text = _calculator.GetDisplay();
        }
    }
   
}
