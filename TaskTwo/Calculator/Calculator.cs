using System;

namespace Calculator
{
    class Calculator
    {
        public bool EnterOperand(out double operand)
        {
            Console.WriteLine("Enter number");
            return double.TryParse(Console.ReadLine(), out operand);
        }

        public bool Calculate(double firstOperand, double secondOperand, char operationSymbol, ref double result)
        {
            bool successFlag = true; 
            switch (operationSymbol)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '^':
                    result = Math.Pow(firstOperand,secondOperand);
                    break;
                case '/':
                    if (secondOperand != 0)
                    {
                        result = firstOperand / secondOperand;
                    }
                    else
                    {
                        successFlag = false;
                        Console.WriteLine("\nDevision by zero is not allowed");
                    }
                    break;
                default:
                    successFlag = false;
                    Console.WriteLine($"\nOperation {operationSymbol} is not supported");
                    break;
            }
            return successFlag;
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double firstOperand, secondOperand;
            if (calculator.EnterOperand(out firstOperand))
            {
                if (calculator.EnterOperand(out secondOperand))
                {
                    Console.WriteLine("Enter operation symbol");
                    char operationSymbol = Console.ReadKey(false).KeyChar;
                    double result = 0;
                    if (calculator.Calculate(firstOperand, secondOperand, operationSymbol, ref result))
                    {
                        Console.WriteLine($"\n-----------------------\n{firstOperand} {operationSymbol} {secondOperand} = {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Second operand is not a number");
                }
            }
            else
            {
                Console.WriteLine("First operand is not a number");
            }
        }
    }
}
