using System;

namespace Homework2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SimpleCalc!\nEnter two numbers and an operand.\n");

            Console.Write("First number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Second number: ");
            string secondtNumber = Console.ReadLine();

            Console.Write("Choose the operand ('+', '-', '*' or '/'): ");
            string operand = Console.ReadLine();

            SimpleCalc(firstNumber, secondtNumber, operand);
        }

        static void SimpleCalc(string sNum1, string sNum2, string operand)
        {
            double number1, number2;
            if ( !(Double.TryParse(sNum1, out number1) && Double.TryParse(sNum2, out number2)))
            {
                Console.WriteLine("Input not a number!");
            } else
            {
                switch (operand)
                {
                    case "+":
                        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
                        break;
                    case "-":
                        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
                        break;
                    case "*":
                        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
                        break;
                    case "/":
                        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong! Try Again!");
                        break;
                }
            }
        }
    }
}
