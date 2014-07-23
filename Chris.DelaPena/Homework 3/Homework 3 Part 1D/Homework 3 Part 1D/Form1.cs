using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_Part_1D
{
    public partial class Form1 : Form
    {
        
        String calculationSelect;
        int calculationValue;
        int diameterResult;
        double areaResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculationSelect = textBox1.Text;
            calculationValue = int.Parse(textBox2.Text);
            if (calculationSelect == "Diameter")
            {
                diameterResult = calculationValue * 2;
                resultBox.Text = diameterResult.ToString();
            } 
            else if (calculationSelect == "Area")
            {
                areaResult = calculationValue * calculationValue * 3.14159;
                resultBox.Text = areaResult.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect Query!!");
            }
        }
    }
}
