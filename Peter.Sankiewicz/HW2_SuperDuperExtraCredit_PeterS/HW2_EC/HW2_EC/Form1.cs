using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_EC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            greetingsLabel.Text = "";
        }

        private void GreetThem(object sender, EventArgs e)
        {
            String userName  = nameField.Text;
            String greeting = "Hello, " + userName;
            greetingsLabel.Text = greeting;
        }

        private void greetingsLabel_Click(object sender, EventArgs e)
        {

        }
        // Options:
        // 1) Display a message box saying "Please enter your name."
        // 2) Have it say "Hello" without a name.
        // 3) Have it say "Hello! What's your name?
        // 4) Add instructions and then display the error message box.
    }
}
