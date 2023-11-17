using System;

namespace Calculator
{
    public class Calculate
    {
        public static void Main()
        {
            // updated
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Available operations: +, -, *, /");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // updated code
            Console.Write("Enter the operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Variable 
            double result = 0;

            switch (op)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }
    }
}
