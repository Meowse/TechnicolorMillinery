using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBrain
{
    public class Calculator
    {
        // The current state of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.

        /*
         * Valid inputs:
         * '0' -- input the digit 0
         * ...
         * '9' -- input the digit 9
         * '+' -- add
         * '-' -- subtract
         * '*' -- multiply
         * '/' -- divide
         * '=' -- perform the current calculation
         * 'c' -- clear
         */
        public string Display = "0";
        public float Operand1;
        public float LastResult = 0f;
        public Operators Operator;
        public CalcState LastState = CalcState.CalcStateNew;
        

        public void ProvideInput(char input)
        {
            if (input == 'c')
            {
                ClearDisplay();
            }
            if (char.IsDigit(input))
            {
                switch (LastState)
                {
                    //state new
                    case CalcState.CalcStateNew:
                    //state clear
                    case CalcState.CalcStateClear:
                    //state operator
                    case CalcState.CalcStateRecievedOperatorInput:

                    //state equal
                    case CalcState.CalcStateDisplayResult:
                        Display = input.ToString();
                        break;
                    
                    //state number
                    case CalcState.CalcStateReceivedNumericInput:
                        Display += input.ToString();
                        break;
                    
                }
                LastState = CalcState.CalcStateReceivedNumericInput;
                //Operator = Operators.OperatorNil;
            }
            if (input == '.')
            {
                switch (LastState)
                {
                    //state new
                    case CalcState.CalcStateNew:
                    //state clear
                    case CalcState.CalcStateClear:
                        Display += input.ToString();
                        break;
                    //state operator 
                    case CalcState.CalcStateRecievedOperatorInput:
                        Display = "0.";
                        break;
                    case CalcState.CalcStateReceivedNumericInput:
                        if (!Display.Contains("."))
                        {
                            Display += input.ToString();
                        }
                        break;
                }
                LastState = CalcState.CalcStateReceivedNumericInput;
                //Operator = Operators.OperatorNil;
            }
            if (input == '+' || input == '-' || input == '*' || input == '/')
            {
                switch (LastState)
                {
                    //state new
                    case CalcState.CalcStateNew:
                    //state clear
                    case CalcState.CalcStateClear:
                        Operand1 = 0.0f;
                        Operator = GetOperator(input);
                        break;
                        //state operator
                    case CalcState.CalcStateRecievedOperatorInput:
                        Operator = GetOperator(input);
                        break;
                        //state number
                    case CalcState.CalcStateReceivedNumericInput:
                        TryCalculate();
                        Operator = GetOperator(input);
                        break;
                        //state equal
                    case CalcState.CalcStateDisplayResult:
                        ClearDisplay();
                        Operator = GetOperator(input);
                        break;
                }
                LastState = CalcState.CalcStateRecievedOperatorInput;

            }
            if (input == '=')
            {
                switch (LastState)
                {
                    case CalcState.CalcStateNew:
                    case CalcState.CalcStateClear:
                        ClearDisplay();
                        break;
                    case CalcState.CalcStateReceivedNumericInput:
                        TryCalculate();
                        //LastResult = TryConvertToFloat(Display);
                        break;
                    case CalcState.CalcStateRecievedOperatorInput:
                        LastResult = TryConvertToFloat(Display);
                        break;
                    case CalcState.CalcStateDisplayResult:
                        //do nothing
                        break;
                }
                LastState = CalcState.CalcStateDisplayResult;
                Operator = Operators.OperatorNil;
            }

        }

        public Operators GetOperator(char input)
        {
            if (input == '+')
            {
                return Operators.OperaterAdd;
            }
            else if (input == '-')
            {
                return Operators.OperatorSubtract;
            }
            else if (input == '*')
            {
                return Operators.OperatorMultiply;
            } else if (input == '/')
            {
                return Operators.OperatorDivide;
            }
            else
            {
                return Operators.OperatorNil;
            }
        }

        public string GetDisplay()
        {
            return Display;
        }

        public void ClearDisplay()
        {
            Display = "0";
            Operand1 = 0.0f;
            Operator = Operators.OperatorNil;
            LastState = CalcState.CalcStateClear;
        }

        public float TryConvertToFloat(string value)
        {
            float fl;
            if (!float.TryParse(value, out fl))
            {
                LastState = CalcState.CalcStateError;
                ClearDisplay();
                throw new InvalidCastException();
                
            }
            return fl;
        }

        public void TryCalculate()
        {
            var currValue = TryConvertToFloat(Display);
            switch (Operator)
            {
                case Operators.OperaterAdd:
                    LastResult = LastResult + currValue;
                    Display = LastResult.ToString();
                    //LastState = CalcState.CalcStateDisplayResult;
                    break;
                case Operators.OperatorSubtract:
                    LastResult = LastResult - currValue;
                    Display = LastResult.ToString();
                    //LastState = CalcState.CalcStateDisplayResult;
                    break;
                case Operators.OperatorMultiply:
                    LastResult = LastResult*currValue;
                    Display = LastResult.ToString();
                    //LastState = CalcState.CalcStateDisplayResult;
                    break;
                case Operators.OperatorDivide:
                    if (currValue == 0)
                    {
                        LastState = CalcState.CalcStateError;
                        ClearDisplay();
                        throw new DivideByZeroException();
                    }
                    else
                    {
                        LastResult = LastResult/currValue;
                        Display = LastResult.ToString();
                        //LastState = CalcState.CalcStateDisplayResult;
                        
                    }
                    break;
                case Operators.OperatorNil:
                    LastResult = currValue;
                    //LastState = CalcState.CalcStateRecievedOperatorInput;
                    break;
            }
        }
        public enum CalcState
        {
            CalcStateNew,
            CalcStateReceivedNumericInput,
            CalcStateRecievedOperatorInput,
            CalcStateDisplayResult,
            CalcStateClear,
            CalcStateError
        }

        public enum Operators
        {
            OperaterAdd,
            OperatorSubtract,
            OperatorMultiply,
            OperatorDivide,
            OperatorNil
        }
    }
}
