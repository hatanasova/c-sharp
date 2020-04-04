using System;

namespace Homework4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            IsPrimeNumber(number);
        }

        static void IsPrimeNumber(int number)
        {
            bool isPrime = true;

            for (int i = 2; i <= (number / 2); i++)
            {
                if ((number % i) == 0)
                    isPrime = false;
            }

            if (isPrime)
                Console.WriteLine(number + " is a prime number.");
            else
                Console.WriteLine(number + " is not a prime number.");
        }
    }
}
