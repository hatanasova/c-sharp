using System;

namespace Homework2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatIsBehindTheDoor();
        }

        static void WhatIsBehindTheDoor()
        {
            Console.WriteLine("Find what's bihnd the door. Options: 1, 2 and 3");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.Write("Wrong input. Try again!");
                    break;
            }
        }
    }
}
