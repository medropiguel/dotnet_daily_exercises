using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1;
            int num2;

            while (true)
            {
                System.Console.WriteLine("Please write the first number");

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    System.Console.WriteLine("Invalid number.");
                    continue;
                }
                break;

            }
            while (true)
            {
                System.Console.WriteLine("Please write the second number");

                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    System.Console.WriteLine("Invalid number.");
                    continue;
                }
                break;
            }
            System.Console.WriteLine($"The sum of both numbers is {num1 + num2}");

        }
    }
}