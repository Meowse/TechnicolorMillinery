using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        private double value = 0;
        private string operation = "0";
        private bool operation_pressed = false;
        
        //  Create List to store inputed numbers from the text box
        private List<string> input_numbers_list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;

            Button b = (Button) sender;

            result.Text = result.Text + b.Text;

            //MessageBox.Show("b text" + b.Text);

            //  Add inputed number to list 
            input_numbers_list.Add(result.Text);

            foreach (var value in input_numbers_list)
            {
                MessageBox.Show(value);
            }
            //MessageBox.Show(input_numbers[0]);

            string listCount = input_numbers_list.Count.ToString();
            MessageBox.Show("List Count: " + listCount);
         

        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                 case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                 case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;

            }//end switch

            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
