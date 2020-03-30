using System;

namespace Homework3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers and get the minimum and maximum.");

            Console.Write("Enter the first number: ");
            string sNum1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string sNum2 = Console.ReadLine();

            Console.Write("Enter the third number: ");
            string sNum3 = Console.ReadLine();

            FindGreatestNumber(sNum1, sNum2, sNum3);
        }

        static void FindGreatestNumber(string a, string b, string c)
        {
            int firstNumber, secondNumber, thirdNumber;
            int.TryParse(a, out firstNumber);
            int.TryParse(b, out secondNumber);
            int.TryParse(c, out thirdNumber);

            Console.WriteLine("Maximum number is: " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));
            Console.WriteLine("Minimum number is: " + Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));
        }
    }
}
