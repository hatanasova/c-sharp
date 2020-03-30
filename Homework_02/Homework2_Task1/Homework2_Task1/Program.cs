using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectApples();
        }

        static void CollectApples()
        {
            int nApples = 22;
            int mBaskets = 5;

            Console.WriteLine("We need " + Math.Ceiling((double)nApples / mBaskets) + " baskets to collect " + nApples);
        }
    }
}