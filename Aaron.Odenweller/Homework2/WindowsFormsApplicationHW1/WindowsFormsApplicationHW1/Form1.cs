using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            lblBomb.Text = "Now You've Done It!!!";
            lblBomb.Visible = false;
            
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Text = "Hello World";
            lblBomb.Visible = false;
            lblHello.Visible = true;
            pictureBox1.Visible = false;
            string text = System.IO.File.ReadAllText(@"C:\Users\Aaron\Documents\GitHub\TechnicolorMillinery\Aaron.Odenweller\Homework1\WindowsFormsApplicationHW1\WindowsFormsApplicationHW1\How to brush your teeth.txt");
            lblHello.Text = text;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Goodbye World";
            lblBomb.Visible = true;
            lblHello.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
