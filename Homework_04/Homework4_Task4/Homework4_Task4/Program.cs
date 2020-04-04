using System;

namespace Homework4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial");
            Console.Write("Numer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            CalculateFactorial(number);
        }

        static void CalculateFactorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial = factorial * i;
            Console.WriteLine("Factorial of " + number + " is " + factorial);
        }
    }
}
