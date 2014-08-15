﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CalculatorBrain;

namespace CalculatorForms
{
    public partial class Form1 : Form
    {
        readonly Calculator _myCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleInput(char input)
        {
            _myCalculator.ProvideInput(input);
            TextDisplay.Text = TextDisplay.Text + input.ToString();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (_myCalculator._hasDecimal == false)
            {
                HandleInput('.');
            }
            
        }
    }
}
