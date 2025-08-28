
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Gabriele", 23);

            person1.Name = "Pedro";
            person1.Age = -3;

            System.Console.WriteLine(
                $"Pessoa 1: {person1.Name}, {person1.Age} anos\n" +
                $"Pessoa 2: {person2.Name}, {person2.Age}"
            );
        }
    }
}