using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int myintegervalue = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = myintegervalue.ToString();
        }


        private void greetButton_Click(object sender, EventArgs e)
        {
            string mystringvalue;
            mystringvalue = "";

// when the greetbutton is clicked, greet either the teacher if it is the teacher, or the person if it is a person.

            if ((mystringvalue = textBox1.Text) == "Mickey")
            {
                MessageBox.Show("Hello, teacher!");
            }
            else
            {
                MessageBox.Show("Hello, " + mystringvalue);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            myintegervalue++;
            if (myintegervalue > 10)
            {
                MessageBox.Show("Number too big");
                myintegervalue = 0;
            }

            label2.Text = myintegervalue.ToString();

        }
    }
}
