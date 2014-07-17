using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Bridget");

        }

        private void howtobrushteeth_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to brush your teeth at a sink\n\nGo to a sink\nGet a toothbrush\nGet your favorite toothpaste\nApply toothpaste to the toothbrush\nFirst hold the toothbrush in your right hand\nHold toothpaste in left hand\nWith the bristles facing upward to the sky\nSqueeze a small amount onto the toothbrush, a little more than a size of a pea\n   turn on the water in your sink\nget the toothbrush with the toothpaste a little wet\n\nPut the toothbrush with toothpaste in your mouth\nGo up and down with your toothbrush\nstart at the upper gum and work your way down the lower gum");

        }

        private void helloBridget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Bridget");
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            //nameText.Select(0, 25);
            //MessageBox.Show("Hello " + nameText.SelectedText);

            // Check for a blank entry
            if (nameText.Text == "")
            {
                // do not print anything
                this.nameLabel.Text = "";
                // display a warning for them to add a name
                this.nameLabel.Text = "Name is a required field, please enter a name.";
            }
            else if (nameText.Text == "Mickey")
            {
                this.nameLabel.Text = "Hello, teacher! ";   
            }
            else
            {
               this.nameLabel.Text = "Hello " + this.nameText.Text;
            }
             
        }

        private void addOne_Click(object sender, EventArgs e)
        {
            // retrieve value on label 
            int x = Convert.ToInt32(nameLabelTwo.Text);
            
            // add 1
            x = x + 1;

            // check if greater than 10
            if (x > 10)
            {
                x = 0;
                MessageBox.Show("Number too big, start again!");
            }
            else
            {
                // blank out
                //nameLabelTwo.Text = "";
            }

            // display total label 
            nameLabelTwo.Text = Convert.ToString(x);
        }
    }
}
