using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Lord of the Rings";
            book1.author = "Tolkien";
            book1.pages = 400;
            System.Console.WriteLine(book1.title);
        }
    }
    
}