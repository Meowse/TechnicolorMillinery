using System;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Decimal _value;
        String _operation;
        bool _operationClicked;
        bool _decimalPointEntered;

        public Form1()
        {
            _value = 0;
            _operation = "";
            _operationClicked = false;
            _decimalPointEntered = false;
            InitializeComponent();
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || _operationClicked)
            {
                // Elimiate Leading zero
                result.Clear();
            }
            _operationClicked = false;
            Button buttonClicked = (Button) sender;
            if (buttonClicked.Text == "." && _decimalPointEntered)
            {
                _decimalPointEntered = true;
            }
            else
            {
                result.Text = result.Text + buttonClicked.Text;
                if (buttonClicked.Text == ".")
                {
                    _decimalPointEntered = true;
                }
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            // Replace display with zero
            equation.Text = ""; 
            result.Text = "0";
            _decimalPointEntered = false;
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
            _operation = buttonClicked.Text;
            _value = Convert.ToDecimal(result.Text);
            _operationClicked = true;
            _decimalPointEntered = false;
            equation.Text = equation.Text + _value + " " + _operation;
            //PerformOperation();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            PerformOperation();
        }

        public void PerformOperation()
        {
            switch (_operation)
            {
                case "+":
                    result.Text = (_value + Convert.ToDecimal(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (_value - Convert.ToDecimal(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (_value*Convert.ToDecimal(result.Text)).ToString();
                    break;
                case "/":
                    if (result.Text != "0")
                    {
                        result.Text = (_value/Convert.ToDecimal(result.Text)).ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed.");
                        break;
                    }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            equation.Text = ""; 
            result.Text = "0";
            _value = 0;
            _decimalPointEntered = false;
        }
    }
}
