using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        { 
            // Updated code
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Available operations: +, -, *, /");

            // Updated
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            // Updated code
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // code
            double result = 0;

            // updated codeeee
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            // updated code
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
