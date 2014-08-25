using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEventHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text += "!!!";

            // += and -= have two different meanings in C#, and they are TRULY
            // DIFFERENT.
            // 
            // 1) The meaning you've already seen, where they mean "take the value
            // on the left, add the value on the right to it, and put it back into
            // the value on the left."  "i += 7" is identical to "i = i + 7".
            //
            // 2) A brand-new meaning having to do with events and event-handling,
            // where they mean "add an event handler to this event, or remove an
            // event handler from this event."
            nikeButton.Click += DoSomething;
        }

        private void DoSomething(object sender, EventArgs e)
        {
            MessageBox.Show("Yep, you clicked Do It!");
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked Other!");
        }

        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            output.Text += "FORM.keyDown"
                + ": KeyCode = " + e.KeyCode
                + "; KeyData = " + e.KeyData
                + "; KeyValue = " + e.KeyValue
                + "; Alt = " + e.Alt
                + "; Control = " + e.Control
                + "; Shift = " + e.Shift
                + "\r\n";
        }

        private void handleKeyPress(object sender, KeyPressEventArgs e)
        {
            output.Text += "FORM.keyPress"
                + ": KeyChar = " + e.KeyChar
                + ", numeric value = " + (int)e.KeyChar
                + "\r\n";

            //if (e.KeyChar == 27)
            if (e.KeyChar == (int)Keys.Escape)
            {
                output.Text += "ESC pressed!  Clear the calculator!\r\n";
            }
            else if (e.KeyChar == '1')
            {
                output.Text += "User typed a 1\r\n";
            }
            else if (e.KeyChar == '=')
            {
                output.Text += "User typed =\r\n";
            }
            else if (e.KeyChar == (int)Keys.Back)
            {
                output.Text += "User pressed backspace\r\n";
            }
        }

        private void handleKeyUp(object sender, KeyEventArgs e)
        {
            output.Text += "FORM.keyUp"
                + ": KeyCode = " + e.KeyCode
                + "; KeyData = " + e.KeyData
                + "; KeyValue = " + e.KeyValue
                + "; Alt = " + e.Alt
                + "; Control = " + e.Control
                + "; Shift = " + e.Shift
                + "\r\n";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void addBlankLineButton_Click(object sender, EventArgs e)
        {
            output.Text += "\r\n";
        }
    }
}
