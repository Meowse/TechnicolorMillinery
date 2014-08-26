using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorForm : Form
    {
        private decimal _currentNumber;
        private decimal _totalValue;
        private bool DecimalInput;
        private bool _convertSign;
        private char _operator;
        private readonly List<char> _listOfOperators;
        private List<string> ListOfCalculatorInputs;
        private string _previousInput;
        private bool DivideByZeroIndicator;

        public CalculatorForm(int i)
        {
            _currentNumber = i;
            InitializeComponent();
            txtResult.Text = _currentNumber.ToString();
            List<char> OperatorList = new List<char>();
            _listOfOperators = OperatorList;
            OperatorList.Add('/');
            OperatorList.Add('+');
            OperatorList.Add('-');
            OperatorList.Add('*');
            List<String> list = new List<string>();
            ListOfCalculatorInputs = list;
            DivideByZeroIndicator = false;
        }


        public void SetDisplay(decimal input)
        {
            txtResult.Text = input.ToString();
        }

        public string GetDisplay()
        {
            return txtResult.Text;
        }

        public void ProvideInput(string input)
        {
            decimal tempDec = 0;
            try
            {
                if (_previousInput == "=")
                {
                    if (Decimal.TryParse(input, out tempDec))
                    {
                        input = "C";
                    }
                    
                }

                var tryDecimalNumber = Decimal.Parse(input);
               
                if (this._convertSign == true)
                {
                    this._currentNumber = tryDecimalNumber;
                }

                else if (DecimalInput == true)  // this doesn't get run after first .0
                {
                    String temp = this._currentNumber.ToString().Replace(".0", "." + input);
                    this._currentNumber = Convert.ToDecimal(temp);

                }

                else
                {
                    if (ListOfCalculatorInputs.Count() == 0 ||  CheckListForMostRecentInput())
                    {
                        this._currentNumber = Convert.ToDecimal(tryDecimalNumber);
                    } // end nested if
                    else
                    {
                        String temp = (string.Format("{0}{1}", this._currentNumber, input));
                        this._currentNumber = Convert.ToDecimal(temp);   
                    } // end nested else

                }

                SetDisplay(this._currentNumber);

                if (DecimalInput != true)  // this does get run during 2nd .0
                {
                    ListOfCalculatorInputs.Add(tryDecimalNumber.ToString());
                }

                DecimalInput = false;

            }
            catch
            {
                this.DecimalInput = false;

                if (_previousInput == "=")
                {
                    _currentNumber = _totalValue;
                    _totalValue = 0;
                    }
                if (input == "C")
                {
                    ListOfCalculatorInputs.Clear();
                    DivideByZeroIndicator = false;
                    SetDisplay(0);
                    _currentNumber = 0;
                    _totalValue = 0;
                    DecimalInput = false;
                    _convertSign = false;
                    _operator = '\0';
                    _previousInput = "";
                    btnDecimal.Enabled = true;
                    btnMakeNegative.Enabled = true;

                }

                else
                {

                    CheckForZeroListCount(Convert.ToChar(input));   //This method adds operator to list if operator was first thing entered in calculator

                    if (CheckListForMostRecentInput())  //if Most recent element in list is operator, then replace it with the new operator
                    {
                        _operator = Convert.ToChar(input);
                        ListOfCalculatorInputs[ListOfCalculatorInputs.Count - 1] = _operator.ToString();
                        //Don't do calculation.

                    } //end nested if

                    else //perform calculation
                    {
                        if (_operator == '\0')
                        {
                            _operator = Convert.ToChar(input);
                        }

                        CalculateTotal();
                        //_operator = Convert.ToChar(input);
                        if (DivideByZeroIndicator != true)
                        {
                            SetDisplay(this._totalValue);                            
                        }

                        ListOfCalculatorInputs.Add(input);  //At this point, the Operator is the previous operator, not the current input
                        
                        if (input != "=") 
                        { 
                        _operator = Convert.ToChar(input);
                        }

                    }//end nested else

                }

            }  // end catch

            _previousInput = input;
        }

        private void DivideByZeroError()
        {
            txtResult.Text = "Divide by 0 Error";
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnDivide.Enabled = false;
            btnAdd.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            btnMakeNegative.Enabled = false;
            btnEquals.Enabled = false;
            btnEquals.Enabled = false;
            btnDecimal.Enabled = false;
        }

        private void CheckForZeroListCount(char input)
        {
            if (ListOfCalculatorInputs.Count == 0)
            {
                ListOfCalculatorInputs.Add("0");
                ListOfCalculatorInputs.Add(input.ToString());
            }
        }

        private bool CheckListForMostRecentInput()
        {
            int countOfElementsInList = ListOfCalculatorInputs.Count;
            for (int i = 0; i < _listOfOperators.Count; i++)
            {
                if (_listOfOperators[i].ToString() == ListOfCalculatorInputs[countOfElementsInList - 1])  //see if last element in calculator is an operator
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckForOperatorExist()
        {
             for (int outer = 0; outer < ListOfCalculatorInputs.Count; outer++)
            {
                for (int inner = 0; inner < _listOfOperators.Count; inner++)
                {
                    if (ListOfCalculatorInputs[outer] == _listOfOperators[inner].ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool SeeIfTheLast4InputsFitModel(string input)
        {
            decimal number;
            char operation;
            if (ListOfCalculatorInputs.Count() < 4)
            {
                return false;
            }
            int Last4Index = ListOfCalculatorInputs.Count() - 4;

            if (Decimal.TryParse(ListOfCalculatorInputs[Last4Index], out number) && Char.TryParse(ListOfCalculatorInputs[Last4Index + 1], out operation) && Decimal.TryParse(ListOfCalculatorInputs[Last4Index + 2], out number) && Char.TryParse(ListOfCalculatorInputs[Last4Index + 3], out operation))
            {
                return true;
            }
            if (Char.TryParse(ListOfCalculatorInputs[Last4Index], out operation) && Decimal.TryParse(ListOfCalculatorInputs[Last4Index + 1], out number) && Decimal.TryParse(ListOfCalculatorInputs[Last4Index + 2], out number) && Char.TryParse(ListOfCalculatorInputs[Last4Index + 3], out operation))
            {
                return true;
            }

            return false;
        }

        private bool SeeIfTheLast3InputsFitModel(string input)
        {
            ListOfCalculatorInputs.Add(input);

            decimal number;
            char operation;
            if (ListOfCalculatorInputs.Count() < 3)
            {
                return false;
            }
            int Last3Index = ListOfCalculatorInputs.Count() - 3;

            if (Decimal.TryParse(ListOfCalculatorInputs[Last3Index], out number) && Char.TryParse(ListOfCalculatorInputs[Last3Index + 1], out operation) && Decimal.TryParse(ListOfCalculatorInputs[Last3Index + 2], out number))
            {
                return true;
            }

            return false;
        }

        private bool LastTwoInputsWereOperators(string previousInput, string input)
        {
            bool previousInputFound = false;
            bool inputFound = false;

            foreach (char c in _listOfOperators)
            {
                if (c.ToString() == previousInput && previousInput != "=")
                {
                    previousInputFound = true;
                }
                if (c.ToString() == input)
                {
                    inputFound = true;
                }
            }
            if (previousInputFound == true && inputFound == true)
            {
                return true;
            }
            return false;
        }

        public void CalculateTotal()
        {

            switch (_operator)
            {
               
                case '+':

                    _totalValue = _totalValue + _currentNumber;
                    _currentNumber = 0;
                    break;

                case '-':

                    if (_totalValue == 0)
                    {
                        _totalValue = _currentNumber;
                        _currentNumber = 0;
                    }
                    else
                    {
                        _totalValue = _totalValue - _currentNumber;
                        _currentNumber = 0;
                    }
                    break;

                case '*':
                    if (CheckForOperatorExist() == false || _previousInput == "=")
                    {
                        _totalValue = 1 * _currentNumber;
                    }
                    else
                    {
                        _totalValue = _totalValue * _currentNumber;  
                    }
                    
                    break;

                case '/':
                    if (CheckForOperatorExist() == false || _previousInput == "=")
                    {
                        _totalValue = _currentNumber;
                    }
                    else if (_currentNumber == 0)
                    {
                        DivideByZeroIndicator = true;
                        DivideByZeroError();
                    }
                    else if (_currentNumber != 0)
                    {
                        _totalValue = _totalValue / _currentNumber;
                    }
                    break;

                case '=':
                    if (CheckForOperatorExist() == false)
                    {
                        _totalValue = _currentNumber;
                    }
                    break;
                default:
                    //ClearDisplay();
                    //SetDisplay("Enter a Valid Character");
                    break;
            }
        }
        // End Perform Operation

        private void btn9_Click(object sender, EventArgs e)
        {
            ProvideInput(btn9.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ProvideInput(btn8.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ProvideInput(btn7.Text);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ProvideInput(btn6.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = true;
            ProvideInput(btn5.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = true;
            ProvideInput(btn4.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ProvideInput(btn3.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ProvideInput(btn2.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ProvideInput(btn1.Text);
            btnMakeNegative.Enabled = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = true;
            ProvideInput(btn0.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = true;
            ProvideInput(btnClear.Text);

        }
        private void btnMakeNegative_Click(object sender, EventArgs e)
        {  
            if (_currentNumber == 0)
            {
                //Don't do anything
            }
            else
            {   // scan list.  if most recent is 
                this._convertSign = true;
                ProvideInput((_currentNumber * -1).ToString());
                this._convertSign = false;
            }

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = true;
            this.DecimalInput = false;
            var temp = _currentNumber.ToString() + btnDecimal.Text;
            ProvideInput(".0");
            btnDecimal.Enabled = false;
            this.DecimalInput = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = false;
            btnDecimal.Enabled = true;
            ProvideInput(btnAdd.Text);

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = false;
            btnDecimal.Enabled = true;
            ProvideInput(btnSubtract.Text);

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = false;
            btnDecimal.Enabled = true;
            ProvideInput(btnMultiply.Text);

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = false;
            btnDecimal.Enabled = true;
            ProvideInput(btnDivide.Text);

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            btnMakeNegative.Enabled = false;
            btnDecimal.Enabled = true;
            ProvideInput(btnEquals.Text);

        }


    }
}
