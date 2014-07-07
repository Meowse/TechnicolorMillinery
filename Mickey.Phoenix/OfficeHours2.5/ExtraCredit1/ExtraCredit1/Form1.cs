using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraCredit1
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
            String userName = nameField.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("Please enter your name, so I can greet you properly!");
            }
            else
            {
                String greeting = "Hello, " + userName;
                greetingsLabel.Text = greeting;
            }
        }

        // Options:
        // 1) Display a message box saying "Please enter your name."
        // 2) Have it say "Hello" without a name.
        // 3) Have it say "Hello!  What's your name?"
        // 4) Add instructions, and then display the error message box.

        // Entering a phone number:
        // 1) Give an example.  E.g.     "Phone Number [                 ]  (xxx-xxx-xxxx)
        // 2) Accept anything they give you that has ten digits and no letters, e.g. (nnn) nnn-nnnn, nnn nnn nnnn, nnn-nnn-nnnn
        // 3) Re-display it in a standard, "canonical" format (e.g. nnn-nnn-nnnn or (nnn) nnn-nnnn)

        // Especially important with dates!
        // What is this date?  2/1/2014
        // Let them enter 2/1/2014, but re-display it as 2014-02-01 (or, even better, "Feb. 01, 2014" if the user will
        // put up with that)
        // 2/1/2014
        // 2014-02-01
        // Feb. 1, 2014 -- no way for the mistake to be un-noticed.
        // 2/1/2014
        // You can always display: 2/1/2014 (February 1, 2014)
    }
}
