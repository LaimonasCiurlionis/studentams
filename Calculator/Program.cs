using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        //Suskleisti methodus => ctrl + m + o
        //Atskleisti methodus => ctrl m + l 

        private static readonly string[] _validOperators = { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
          
        }

        private static double GetNumberFromConsole() 
        {
            bool isCorrectNumber = false;
            double argumentValue = 0;

            while (!isCorrectNumber) 
            {
                Console.WriteLine("Enter a number or Q to exit");
                string userInputValue = Console.ReadLine();

                CheckApplicationExit(userInputValue);

                if (double.TryParse(userInputValue, out argumentValue))
                {
                    isCorrectNumber = true;
                }
                else 
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            return argumentValue;
        }

        private static string GetOperatorFromConsole() 
        {
            bool isCorrectOperator = false;
            string operatorValue = string.Empty;

            while (!isCorrectOperator) 
            {
                Console.WriteLine($"Enter an operator or Q to exit. Allowed operators: {string.Join(", ", _validOperators)}");
                string userInputValue = Console.ReadLine();

                CheckApplicationExit(userInputValue);

                if (IsOperatorValid(userInputValue))
                {
                    operatorValue = userInputValue;
                    isCorrectOperator = true;
                }
                else 
                {
                    Console.WriteLine("Please enter a valid operator");
                }
            }

            return operatorValue;
        }

        private static bool IsOperatorValid(string userInputValue) 
        {
            //bool isOperatorValid = _validOperators.Contains(userInputValue);
            //return isOperatorValid;
            return _validOperators.Contains(userInputValue);
        }

        private static void CheckApplicationExit(string input) 
        {
            if (input.Equals("q", StringComparison.OrdinalIgnoreCase)) 
            {
                CloseApplication();
            }
        }
        
        private static void CloseApplication() 
        {
            Console.WriteLine("Goodbey, thank you for using our Calculator");
            Console.WriteLine("Press any key to close application....");
            Environment.Exit(0);
        }
    }
}
