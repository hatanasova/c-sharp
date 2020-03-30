using System;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string number2 = Console.ReadLine();

            MaxOfTwoNumbers(number1, number2);
        }

        static void MaxOfTwoNumbers(string a, string b)
        {
            int num1, num2;

            if (!(int.TryParse(a, out num1) && int.TryParse(b, out num2)))
            {
                Console.WriteLine("Wrong Input! Try again!");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                if (num1 > num2)
                    Console.WriteLine("The bigger number is: " + num1);
                else
                    Console.WriteLine("The bigger number is: " + num2);
            }
        }

    }
}
