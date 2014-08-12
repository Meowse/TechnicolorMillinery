using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorBrain;

namespace CalculatorConsoleApplication
{
    class CalculatorConsole
    {
        private static String _input;

        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            aCalculator.SetDisplay("Type 'Exit' to exit." + " Other than 'Exit', valid inputs are: digits 0 - 9, '+','-','*','/','=', or 'c' ");
            Console.WriteLine(aCalculator.GetDisplay(aCalculator));
            aCalculator.ClearDisplay();
 
            do
            {
              _input = Console.ReadLine().Trim();  //will bomb if null
                
                if (_input != "Exit")
                {
                    performNumberVerification(aCalculator, _input);
                    aCalculator.setNumber(_input);
                    aCalculator.SetDisplay(_input);
                    Console.WriteLine(aCalculator.GetDisplay(aCalculator) + " was entered.  What operation do you want to perform?");
                    
                    do
                    {
                        _input = Console.ReadLine().Trim();
                        validateOperator(aCalculator);
                        aCalculator.setOperation(_input);
                        if (_input != "c" && _input != "=")
                        {
                            Console.WriteLine("Enter a Number");
                            _input = Console.ReadLine().Trim();
                            performNumberVerification(aCalculator, _input);
                        }

                        aCalculator.PerformOperation(_input);
                        Console.WriteLine("Operations: " + aCalculator.GetDisplay(aCalculator) + ". What do you want to do next?");
                    } while (_input != "Exit");


                    //aCalculator.Operation(_input);
                    //take value and wait for User input to perform operation

                    //var response = TriangleTyper.GetTriangleType(long.Parse(arrayOfInputs[0]), long.Parse(arrayOfInputs[1]), long.Parse(arrayOfInputs[2]));
                    //Console.WriteLine(response);
                }
                
            } while (_input != "Exit");

        }

        private static void performNumberVerification(Calculator aCalculator, String input)
        {
            bool validClearOperator = input.Equals("c");
            bool digitEntered = aCalculator.DecimalValueEntered(_input);
            while (digitEntered == false && _input != "Exit" && validClearOperator == false)
            {
                Console.WriteLine("Decimal Number Only");
                _input = Console.ReadLine().Trim();
                digitEntered = aCalculator.DecimalValueEntered(_input);

            }
             
        }

        private static void validateOperator(Calculator tempCalculator)
        {
           
            while (_input != "Exit" && checkOperator(_input) == false)
            {
                Console.WriteLine("Please enter valid operator. Either: '+','-','*','/','=', or 'c'");
                Console.WriteLine(tempCalculator.GetDisplay(tempCalculator));

                _input = Console.ReadLine().Trim();
                
            }

        }

        private static bool checkOperator(string input)
        {
            bool stop = false;
            char temp = Convert.ToChar(input);

            switch (temp)
            {

                case '+':
                    stop = true;
                    break;

                case '-':
                    stop = true;
                    break;

                case '*':
                    stop = true;
                    break;

                case '/':
                    stop = true;
                    break;

                case '=':
                    stop = true;
                    break;

                case 'c':
                    stop = true;
                    break;

                default:
                    stop = false;
                    break;
                  
            }

            return stop;
        } 

     }
}
