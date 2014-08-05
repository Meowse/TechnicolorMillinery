using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greet_Me___HW_Part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            Console.Write("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Happy Birthday {0}!", name);
            Console.ReadLine(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
