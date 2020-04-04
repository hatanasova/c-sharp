using System;

namespace Homework4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Up to what number you want to find the cube?");
            Console.Write("Number = ");
            string numLimit = Console.ReadLine();

            int number;
            int.TryParse(numLimit, out number);

            FindCube(number);
        }

        static void FindCube(int num)
        {
            for (int i = 1; i <= num; i++)
                Console.WriteLine("Number is " + i + " and its cube is " + (i * i * i));
        }
    }
}
