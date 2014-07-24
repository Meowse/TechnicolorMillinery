using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetings_HW3
{
    public partial class IntroductionBox : Form
    {
        String now;
        String UserName;
        public IntroductionBox()
        {
            InitializeComponent();
        }

        private void GreetButton_Click(object sender, EventArgs e)
        {
            {
                String UserName = NameField.Text;
        
                if (UserName.Length == 0)
                {
                    MessageBox.Show("Oops, please enter your name above.");

                }
                else
                {
                    String Greeting = "Hello, " + UserName + "!";

                    GreetingLabel.Text = Greeting;
                }
                if (UserName == "Mickey")
                {
                    GreetingLabel.Text = "Hello, teacher!";
                }

            }

        }

        private void BdayButton_Click(object sender, EventArgs e)
        {
            String BirthDate = BirthdayText.Text;
            String Username = GreetingLabel.Text;
            now = DateTime.Today.ToString("MM/DD");
        
        if (BirthDate.Length == 0)
        {
            MessageBox.Show("Please enter your birthdate in the form MM/DD/YYYY");
        }
            if (BirthDate == now)
            {
                MessageBox.Show("Happy birthday to you/n" 
                   + "Happy birthday to you/n"
                   + "Happy birthday dear" + UserName + "!"
                , "Happy Birthday!");
            }
        
    
    }
       

        }
    }
