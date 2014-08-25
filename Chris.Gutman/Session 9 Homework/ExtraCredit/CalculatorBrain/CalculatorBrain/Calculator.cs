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
        public enum Operator { None, Addition, Subtraction, Multiplication, Division}


        public enum CurrentNumber {FirstNo, UsingAccumulator, SecondNo}
        public static string Displayvalue = "0";
        public static decimal Accumulator = 0;
        public static CurrentNumber CurrentNumberInUse = CurrentNumber.FirstNo;
        public static Operator MostRecentOperator = Operator.None;
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
            const string decimalmatchstring = @"[\d\.\b]";
            const string operatormatchstring = @"[\+\-=\*/]";
            var reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;

// if the input is 'c' reset everything and return

            if(ProcessClear(input))return;

// Regular expression looks to match the input to any single character integer or '.'

            var re = new Regex(decimalmatchstring);
            var rematch = re.Match(input.ToString());
            var inputIsSingleCharIntegerOrPeriod = rematch.Success;

// Regular expression looks to match the input to any single character operator

            var ret =  new Regex(operatormatchstring);
            var retmatch = ret.Match(input.ToString());
            var inputIsSingleCharOperator = retmatch.Success;

//
            switch (CurrentNumberInUse)
            {
                    case CurrentNumber.FirstNo:

                    if (inputIsSingleCharIntegerOrPeriod)
                    {
                        if (input == '\b')
                        {
                            Displayvalue = (Displayvalue.Length>0)? Displayvalue.Substring(0, Displayvalue.Length - 1): "";
                        }
                        else
                        {
                            Displayvalue = (Displayvalue == "0") ? input.ToString() : (Displayvalue + input.ToString());
                        }
                        return;
                    }
                    else if (inputIsSingleCharOperator)
                    {
                        if (Displayvalue != "")
                        {
                            Accumulator = Convert.ToDecimal(Displayvalue);
                        }
                        else
                        {
                            Accumulator = 0;
                        }
                        Lastopcomplete = true;
                        switch (input)
                        {
                        case '+':
                            MostRecentOperator = Operator.Addition;
                            CurrentNumberInUse = CurrentNumber.SecondNo;

                            break;
                        case '-':
                            MostRecentOperator = Operator.Subtraction;
                            CurrentNumberInUse = CurrentNumber.SecondNo;

                            break;
                        case '*':
                            MostRecentOperator = Operator.Multiplication;
                            CurrentNumberInUse = CurrentNumber.SecondNo;
                           
                            break;
                        case '/':
                            MostRecentOperator = Operator.Division;
                            CurrentNumberInUse = CurrentNumber.SecondNo;                            
                            
                            break;
                        case '=':
                                Lastopcomplete = false;
                            break;
                        }
                    }
                    break;

                    case (CurrentNumber.SecondNo):
                    if (inputIsSingleCharIntegerOrPeriod)
                    {
                        if (Lastopcomplete)
                        {
                            if (input == '\b')
                            {
                                // do nothing
                            }
                            else
                            {
                                Displayvalue = input.ToString();
                                Lastopcomplete = false;
                            }
                        }
                        else
                        {
                            if (input == '\b')
                            {
                                Displayvalue = (Displayvalue.Length > 0) ? Displayvalue.Substring(0, Displayvalue.Length - 1) : "";
                            }
                            else
                            {
                                Displayvalue = Displayvalue + input;
                            }

                        }
                        return;
                    }
                    else if (inputIsSingleCharOperator)
                    {
                        CurrentNumberInUse = CurrentNumber.UsingAccumulator;
                        Lastopcomplete = true;
                        switch (input)
                        {

                        case '+':
                            ProcessOperation();
                            MostRecentOperator = Operator.Addition;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '-':
                            ProcessOperation();
                            MostRecentOperator = Operator.Subtraction;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '*':
                            ProcessOperation();
                            MostRecentOperator = Operator.Multiplication;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '/':
                            ProcessOperation();
                            MostRecentOperator = Operator.Division;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '=':
                            ProcessOperation();
                            MostRecentOperator = Operator.None;
                            Displayvalue = Accumulator.ToString();
                            CurrentNumberInUse = CurrentNumber.FirstNo;
                            break;
                        }
                    }
                    break;
                    
                    case  CurrentNumber.UsingAccumulator:
                    if (inputIsSingleCharIntegerOrPeriod)
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
                        CurrentNumberInUse = CurrentNumber.UsingAccumulator;
                        Lastopcomplete = true;
                        switch (input)
                        {
                        case '+':
                            ProcessOperation();
                            MostRecentOperator = Operator.Addition;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '-':
                            ProcessOperation();
                            MostRecentOperator = Operator.Subtraction;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '*':
                            ProcessOperation();
                            MostRecentOperator = Operator.Multiplication;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '/':
                            ProcessOperation();
                            MostRecentOperator = Operator.Division;
                            Displayvalue = Accumulator.ToString();
                            break;
                        case '=':
                            ProcessOperation();
                            MostRecentOperator = Operator.None;
                            CurrentNumberInUse = CurrentNumber.FirstNo;
                            Displayvalue = Accumulator.ToString();
                            break;
                        }
                    }
                    break;
             }
        }

        private bool ProcessClear(char input0)
        {
            if (input0 == 'c')
            {
                CurrentNumberInUse = CurrentNumber.FirstNo;
                MostRecentOperator = Operator.None;
                Displayvalue = "0";
                Lastopcomplete = true;
                Accumulator = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetDisplay()
        {
            return Displayvalue;
        }

        public void ProcessOperation()
        {
            switch (MostRecentOperator)
            {
                case Operator.Addition:
                    Accumulator = Accumulator + Convert.ToDecimal(Displayvalue);
                    break;

                case Operator.Subtraction:
                    Accumulator = Accumulator - Convert.ToDecimal(Displayvalue);
                    break;

                case Operator.Multiplication:
                    Accumulator = Accumulator * Convert.ToDecimal(Displayvalue);
                    break;

                    case Operator.Division:
                    if (Displayvalue != "0")
                    {
                        Accumulator = Accumulator/Convert.ToDecimal(Displayvalue);
                    }
                    else
                    {
                        Displayvalue = "Error";
                        Accumulator = 0;
                    }
                    break;


            }


               
            
        }
    }
}
