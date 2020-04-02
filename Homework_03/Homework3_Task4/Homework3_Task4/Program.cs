using System;

namespace Homework3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Celcius and get the " +
                "weather description.");

            Console.Write("temp = ");
            string sTemp = Console.ReadLine();
            int temp = 0;
            if (!int.TryParse(sTemp, out temp))
                Console.WriteLine("Input is not integer!");
            else
                DisplayMessage(temp);
        }
        static void DisplayMessage(int temp)
        {
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            else if (temp < 10)
                Console.WriteLine("Very Cold weather");
            else if (temp < 20)
                Console.WriteLine("Cold weather");
            else if (temp < 30)
                Console.WriteLine("Normal weather");
            else if (temp < 40)
                Console.WriteLine("Hot weather");
            else
                Console.WriteLine("Very Hot weather");
        }
    }
}
