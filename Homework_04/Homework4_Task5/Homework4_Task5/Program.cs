using System;

namespace Homework4_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and find the sum.");
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            FindSum(number);
        }

        static void FindSum(int number)
        {
            int sum = 0;
            int i = number;

            while (i >= 0)
            {
                sum += i;
                i--;
            }

            Console.WriteLine("Sum of all numbers up to " + number + " is " +
                sum);
        }
    }
}
