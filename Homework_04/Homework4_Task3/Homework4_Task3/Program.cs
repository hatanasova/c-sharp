using System;

namespace Homework4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num + 1; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
