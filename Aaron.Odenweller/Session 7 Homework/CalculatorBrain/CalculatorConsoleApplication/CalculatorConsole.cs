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
      
        static void Main()
        {   
            Calculator aCalculator = new Calculator(0);
            Console.WriteLine(aCalculator.GetDisplay(aCalculator));
            Console.WriteLine();
            aCalculator.ClearDisplay();
 
            do
            {
              _input = Console.ReadLine().Trim();  //will bomb if null
              verifyExit(_input);
              verifyClear(_input, aCalculator);
                    performNumberVerification(aCalculator, _input);
                    aCalculator.setNumber(_input);
                    aCalculator.SetDisplay(_input);
                    Console.WriteLine(aCalculator.GetDisplay(aCalculator) + " was entered.  What operation do you want to perform?");
                    
                    do
                    {
                        _input = Console.ReadLine().Trim();
                        verifyExit(_input);
                        verifyClear(_input, aCalculator);
                        validateOperator(aCalculator);
                        aCalculator.setOperation(_input);
                        if (_input != "c" && _input != "=")
                        {
                            Console.WriteLine("Enter a Number");
                            _input = Console.ReadLine().Trim();
                            verifyExit(_input);
                            verifyClear(_input, aCalculator);
                            performNumberVerification(aCalculator, _input);
                        }

                        aCalculator.PerformOperation(_input);
                        Console.WriteLine(aCalculator.GetDisplay(aCalculator) + ". What do you want to do next?");
                    } while (_input != "Exit");

          
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
                verifyExit(_input);
                verifyClear(_input, aCalculator);
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
                verifyExit(_input);
                verifyClear(_input, tempCalculator);
                
            }
        }

        private static void verifyExit(string input)
        {
            if (input.ToLower().Trim().Equals("exit"))
            {
                Environment.Exit(0);
            }
        }

        private static void verifyClear(string input, Calculator aCalculator)
        {
            if (input.ToLower().Trim().Equals("c"))
            {
                aCalculator.ClearMemory();
                aCalculator.ClearDisplay();
                Main();
            }
        }

        private static bool checkOperator(string input)
        {
            bool stop = false;
            try
            {
                Convert.ToChar(input);
            }
            catch (Exception)
            {

                return false;
            }


            switch (Convert.ToChar(input))
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
