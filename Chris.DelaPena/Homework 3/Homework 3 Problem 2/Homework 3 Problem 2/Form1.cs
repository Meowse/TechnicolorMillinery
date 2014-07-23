using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_Problem_2
{
    public partial class Form1 : Form
    {
        String userName;
        String birthDate;
        String now;
        public Form1()
        {
            InitializeComponent();
        }

        private void birthdayBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) { }


        private void Form1_Load(object sender, EventArgs e)
        {
            userName = nameBox.Text;
            birthDate = birthdayBox1.Text;
            now = DateTime.Today.ToString("MM/d");
            if (birthDate == now)
            {
                MessageBox.Show("Happy birthday to you!\n"
                                    + "Happy birthday to you!\n"
                                       + "Happy birthday dear " + userName
                                        + " Happy birthday to you!");
            }
            else
            {
                MessageBox.Show("Good day!");
            }
        }
    }
}
