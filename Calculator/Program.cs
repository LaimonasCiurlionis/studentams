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
            while (true) 
            {
                try
                {
                    double firstNum = GetNumberFromConsole();
                    double secondNum = GetNumberFromConsole();
                    string operatorValue = GetOperatorFromConsole();

                    double result = PerformCalculation(firstNum, secondNum, operatorValue);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occured: {ex.Message}");
                }
            }
        }

        public static double PerformCalculation(double firstNum, double secondNum, string operation) 
        {
            double result = 0;
            switch (operation) 
            {
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Minus(firstNum, secondNum);
                    break;
                case "*":
                    result = Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = Divide(firstNum, secondNum);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
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

        private static double Add(double firstNum, double secondNum) 
        {
            //double sum = firstNum + secondNum;
            //return sum;
            return firstNum + secondNum;
        }

        private static double Minus(double firstNum, double secondNum) 
        {
            return firstNum - secondNum;
        }

        private static double Multiply(double firstNum, double secondNum) 
        {
            return firstNum * secondNum;
        }

        private static double Divide(double firstNum, double secondNum) 
        {
            if (secondNum == 0) 
            {
                throw new DivideByZeroException("Can not devide by zero!!! Go learn some math.");
            }

            return firstNum / secondNum;
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
