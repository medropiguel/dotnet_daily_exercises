using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool ok = false;


            while (!ok)
            {
                System.Console.WriteLine("Please type a whole number");

                if (!int.TryParse(Console.ReadLine(), out age))
                {

                    continue;
                }
                System.Console.WriteLine("If statements: " + AgeClassifier_if(age));
                System.Console.WriteLine("Ternary Operator: " + AgeClassifier_Ternary(age));
                ok = true;
            }
        }

        static string AgeClassifier_if(int age)
            {
                if (age < 12)
                {
                    return "Kid";
                }
                else if (age <= 17)
                {
                    return "Adolescent";
                }
                else if (age <= 59)
                {
                    return "Adult";
                }
                else
                {
                    return "Elderly";
                }
            }

        static string AgeClassifier_Ternary (int age)
        {
            return age < 12 ? "Kid" : age <= 17 ? "Adolescent" : age <= 59 ? "Adult" : "Elderly";
        }
    }
}