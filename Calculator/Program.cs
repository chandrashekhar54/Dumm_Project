using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void main()
        { 
            // Simple calculator
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Available operations: +, -, *, /");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()   );

            Console.Write("Enter the operator: ");


            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

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

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
