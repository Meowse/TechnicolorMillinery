﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeHours2._5Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNamedItRight(object sender, EventArgs e)
        {
            new NamedItRightThisTime.Form1().Show();
        }

        private void ShowOtherGoodName(object sender, EventArgs e)
        {
            new OtherGoodName.Form1().Show();
        }

        private void SayHello(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, cruel world!", "Hello There!");
        }

        private void TellMeHowToBrush(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Step 1: get toothbrush\n"
                + "Step 2: get toothpaste\n"
                + "Step 3: etc.",
                "Tooth-Brushing Instructions");
        }
    }
}
