using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CalculatorBrain
{
    public class Calculator
    {
        public enum CalculatorState { Waiting, Adding, Subtracting, Multiplying, Dividing}


        public enum InputState {EnteringFirstNo, UsingSavedNo, EnteringSecondNo}
        public static string Displayvalue = "0";
        public static decimal Savednumber = 0;
        public static InputState Inputstate = InputState.EnteringFirstNo;
        public static CalculatorState Calcstate = CalculatorState.Waiting;
        public static bool Lastopcomplete = true;

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
        public void ProvideInput(char input)
        {


 //Replace regular expression with .net string method '.Contains'

            if ((Displayvalue.Contains(".")) & (input == '.'))
            {
                return;
            }

//State Machine. (Switch over and try to use an enum for this).

            ProcessStateMachine(input);
        }
        private void ProcessStateMachine(char input)
        {   
            const string integermatchstring = @"\d|\.";
            const string operationmatchstring = @"[\+\-=\*/]";
            var reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;

// if the input is 'c' reset everything and return

            if (input == 'c')
            {
                Inputstate = InputState.EnteringFirstNo;
                Calcstate = CalculatorState.Waiting;
                Displayvalue = "0";
                Lastopcomplete = true;
                Savednumber = 0;
                return;
            }

// Regular expression looks to match the input to any single character integer or '.'

            var re = new Regex(integermatchstring);
            var rematch = re.Match(input.ToString());
            var inputIsSingleCharInteger = rematch.Success;

// Regular expression looks to match the input to any single character operator

            var ret =  new Regex(operationmatchstring);
            var retmatch = ret.Match(input.ToString());
            var inputIsSingleCharOperator = retmatch.Success;

//
            switch (Inputstate)
            {
                    case InputState.EnteringFirstNo:

                    if (inputIsSingleCharInteger)
                    {
                        Displayvalue = (Displayvalue=="0")?  input.ToString(): (Displayvalue + input.ToString());
                        return;
                    }
                    else if (inputIsSingleCharOperator)
                    {
                        if (Displayvalue != "")
                        {
                            Savednumber = Convert.ToDecimal(Displayvalue);
                        }
                        else
                        {
                            Savednumber = 0;
                        }
                        Lastopcomplete = true;
                        switch (input)
                        {
                        case '+':
                            Calcstate = CalculatorState.Adding;
                            Inputstate = InputState.EnteringSecondNo;

                            break;
                        case '-':
                            Calcstate = CalculatorState.Subtracting;
                            Inputstate = InputState.EnteringSecondNo;

                            break;
                        case '*':
                            Calcstate = CalculatorState.Multiplying;
                            Inputstate = InputState.EnteringSecondNo;
                           
                            break;
                        case '/':
                            Calcstate = CalculatorState.Dividing;
                            Inputstate = InputState.EnteringSecondNo;                            
                            
                            break;
                        case '=':
                                Lastopcomplete = false;
                            break;
                        }
                    }
                    break;

                    case (InputState.EnteringSecondNo):
                    if (inputIsSingleCharInteger)
                    {
                        if (Lastopcomplete)
                        {
                            Displayvalue = input.ToString();
                            Lastopcomplete = false;
                        }
                        else
                        {
                            Displayvalue = Displayvalue + input;
                        }
                        return;
                    }
                    else if (inputIsSingleCharOperator)
                    {
                        Inputstate = InputState.UsingSavedNo;
                        Lastopcomplete = true;
                        switch (input)
                        {

                        case '+':
                            ProcessOperation();
                            Calcstate = CalculatorState.Adding;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '-':
                            ProcessOperation();
                            Calcstate = CalculatorState.Subtracting;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '*':
                            ProcessOperation();
                            Calcstate = CalculatorState.Multiplying;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '/':
                            ProcessOperation();
                            Calcstate = CalculatorState.Dividing;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '=':
                            ProcessOperation();
                            Calcstate = CalculatorState.Waiting;
                            Displayvalue = Savednumber.ToString();
                            Inputstate = InputState.EnteringFirstNo;
                            break;
                        }
                    }
                    break;
                    
                    case  InputState.UsingSavedNo:
                    if (inputIsSingleCharInteger)
                    {
                        if (Lastopcomplete)
                        {
                            Displayvalue = input.ToString();
                            Lastopcomplete = false;
                        }
                        else
                        {
                            Displayvalue = Displayvalue + input;
                        }
                        return;
                    }
                    else if (inputIsSingleCharOperator)
                    {
                        Inputstate = InputState.UsingSavedNo;
                        Lastopcomplete = true;
                        switch (input)
                        {
                        case '+':
                            ProcessOperation();
                            Calcstate = CalculatorState.Adding;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '-':
                            ProcessOperation();
                            Calcstate = CalculatorState.Subtracting;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '*':
                            ProcessOperation();
                            Calcstate = CalculatorState.Multiplying;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '/':
                            ProcessOperation();
                            Calcstate = CalculatorState.Dividing;
                            Displayvalue = Savednumber.ToString();
                            break;
                        case '=':
                            ProcessOperation();
                            Calcstate = CalculatorState.Waiting;
                            Inputstate = InputState.EnteringFirstNo;
                            Displayvalue = Savednumber.ToString();
                            break;
                        }
                    }
                    break;
             }
        }

        public string GetDisplay()
        {
            return Displayvalue;
        }

        public void ProcessOperation()
        {
            switch (Calcstate)
            {
                case CalculatorState.Adding:
                    Savednumber = Savednumber + Convert.ToDecimal(Displayvalue);
                    break;

                case CalculatorState.Subtracting:
                    Savednumber = Savednumber - Convert.ToDecimal(Displayvalue);
                    break;

                case CalculatorState.Multiplying:
                    Savednumber = Savednumber * Convert.ToDecimal(Displayvalue);
                    break;

                    case CalculatorState.Dividing:
                    if (Displayvalue != "0")
                    {
                        Savednumber = Savednumber/Convert.ToDecimal(Displayvalue);
                    }
                    else
                    {
                        Displayvalue = "Error";
                        Savednumber = 0;
                    }
                    break;


            }


               
            
        }
    }
}
