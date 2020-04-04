using System;

namespace Homework4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The even numbers up to 100 are: ");

            int i = 0;

            while (i <= 100)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
}
