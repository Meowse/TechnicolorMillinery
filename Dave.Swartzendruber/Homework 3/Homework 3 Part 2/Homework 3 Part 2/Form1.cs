using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_Part_2
{
    public partial class Form1 : Form
    {
        private int addToText;
        public Form1()
         
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e){
           
               addToText =0;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addToText++;
            displayNum.Text = addToText.ToString();
        }
    }
}
