using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            System.Console.WriteLine("Please type your name:");
            name = Console.ReadLine();

            System.Console.WriteLine("Please type your age:");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                System.Console.WriteLine("Idade inválida!");
                return;
            }
            System.Console.WriteLine($"Hello, {name}! You have {age} years.");
        }
    }
}