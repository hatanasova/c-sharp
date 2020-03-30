using System;

namespace Homework3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To check if a triangle is valid, enter the length of the three sides: ");

            Console.Write("Length of side one: ");
            string sideOne = Console.ReadLine();

            Console.Write("Length of side two: ");
            string sideTwo = Console.ReadLine();

            Console.Write("Length of side three: ");
            string sideThree = Console.ReadLine();

            if (CheckTriangleValidity(sideOne,sideTwo, sideThree) == 1)
                Console.WriteLine("The triangle is valid.");
            else
                Console.WriteLine("The triangle is not valid.");
        }

        static int CheckTriangleValidity(string a, string b, string c)
        {
            double sideOne, sideTwo, sideThree;
            Double.TryParse(a, out sideOne);
            Double.TryParse(b, out sideTwo);
            Double.TryParse(c, out sideThree);

            if (sideOne + sideTwo < sideThree || sideOne + sideThree < sideTwo || sideTwo + sideThree < sideOne)
                return 0;
            else
                return 1;
        }
    }
}
