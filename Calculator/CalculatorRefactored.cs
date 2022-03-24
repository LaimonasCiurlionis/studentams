using System;
using System.Linq;

namespace Calculator
{
    public class CalculatorRefactored
    {
        private static readonly string[] _validOperators = { "+", "-", "*", "/" };

        static void MainCopy()
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
            return operation switch
            {
                "+" => Add(firstNum, secondNum),
                "-" => Minus(firstNum, secondNum),
                "*" => Multiply(firstNum, secondNum),
                "/" => Divide(firstNum, secondNum),
                _ => 0
            };
        }

        private static double GetNumberFromConsole()
        {
            bool isCorrectNumber = false;
            double argumentValue = 0;

            while (!isCorrectNumber)
            {
                string userInputValue = GetUserInput(true);

                CheckApplicationExit(userInputValue);

                isCorrectNumber = double.TryParse(userInputValue, out argumentValue);

                if (!isCorrectNumber) 
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
                string userInputValue = GetUserInput(false);

                CheckApplicationExit(userInputValue);

                isCorrectOperator = IsOperatorValid(userInputValue);
                operatorValue = userInputValue;

                if (!isCorrectOperator) 
                {
                    Console.WriteLine("Please enter a valid operator");
                }
            }

            return operatorValue;
        }

        private static double Add(double firstNum, double secondNum)
        {
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

        private static string GetUserInput(bool isNumber) 
        {
            if (isNumber)
            {
                Console.WriteLine("Enter a number or Q to exit");
            }
            else 
            {
                Console.WriteLine($"Enter an operator or Q to exit. Allowed operators: {string.Join(", ", _validOperators)}");
            }

            return Console.ReadLine();
        }
    }
}
