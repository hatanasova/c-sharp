using System;

namespace Homework3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "Enter the length of the triangle sides and find out " +
                "wheather the triangle is Equilateral, Isosceles " +
                "or Scalene"
            );

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (CheckTriangleValidity(a, b, c) == 1) 
                CheckTriangleType(a, b, c);
            else
                Console.WriteLine("The triangle is not valid! Enter the correct side lengths.");

        }

        static void CheckTriangleType(double sideOne, double sideTwo, double sideThree)
        {

            if (sideOne == sideTwo && sideTwo == sideThree)
                Console.WriteLine("The triangle is equilateral.");
            else if (sideOne == sideTwo || sideTwo == sideThree || sideThree == sideOne)
                Console.WriteLine("The triangle is isosceles");
            else 
                Console.WriteLine("The triangle is scalene");
        }

        static int CheckTriangleValidity(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
                return 0;
            else
                return 1;
        }
    }
}
