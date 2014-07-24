using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            String userName = nameField.Text;
            String greeting = "Hello, " + userName;
            greetingsLabel.Text = greeting;
        }
    }
}
