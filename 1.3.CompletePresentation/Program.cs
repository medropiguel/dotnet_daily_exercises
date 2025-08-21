class Program
{
    static void Main(string[] args)
    {
        string name= "";
        bool nameOk = false;
        string city = "";
        bool cityOk = false;
        bool ageOk = false;
        int age = 0;

        while (!nameOk)
        {
            System.Console.WriteLine("Please write your name.");
            string inputName = Console.ReadLine();
            if (inputName.Trim() != "")
            {
                name = inputName;
                nameOk = true;
            }
        }

        while (!cityOk)
        {
            System.Console.WriteLine("Please write your city.");
            string inputCity = Console.ReadLine();
            if (inputCity.Trim() != "")
            {
                city = inputCity;
                cityOk = true;
            }
        }

        while (!ageOk)
        {
            System.Console.WriteLine("Please write your age.");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                System.Console.WriteLine("Invalid number. Please write a whole number.");
                continue;
            }
            ageOk = true;
        }

        System.Console.WriteLine($"Hello, {name}! You are {age} years old and live in {city}.");  
    }
}