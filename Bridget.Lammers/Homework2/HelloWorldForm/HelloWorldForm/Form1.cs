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
            MessageBox.Show("How to brush your teeth at a sink\n" +
                            "Go to a sink\n" +
                            "Get a toothbrush\n" +
                            "Get your favorite toothpaste\n" +
                            "\n" +
                            "Apply toothpaste to the toothbrush\n" +
                            "First hold the toothbrush in your right hand\n" +
                            "Hold toothpaste in left hand\n" +
                            "With the bristles facing upward to the sky\n" +
                            "Squeeze a small amount onto the toothbrush, a little more than a size of a pea\n" +
                            "turn on the water in your sink\n" +
                            "get the toothbrush with the toothpaste a little wet\n" +
                            "\n" +
                            "Put the toothbrush with toothpaste in your mouth\n" +
                            "Go up and down with your toothbrush\n" +
                            "start at the upper gum and work your way down the lower gum");

        }
    }
}
