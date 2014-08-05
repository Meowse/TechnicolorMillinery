using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4_Part_1
{
    public partial class Form1 : Form
    {
        int songLine = 0;

        public Form1()
        {
            ComponentModel ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sing happy birthday using while loop
            while(songLine < 4)
            {
                    MessageBox.Show("Happy birthday dear user!");
                    songLine++;      
            }
        }
    }
}