using System;

namespace Homework4_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All prime numbers to 100: ");
            int i, j;

            for (i = 2; i <= 100; i++) {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (j == i)
                    Console.Write("\t" + i);
            }

        }
    }
}
