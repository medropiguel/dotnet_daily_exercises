using Model;

namespace Program

{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount number1 = new BankAccount("Pedro");
            System.Console.WriteLine(number1.ShowBalance());
            number1.Deposit(100);
            System.Console.WriteLine(number1.ShowBalance());
            number1.Withdraw(50);
            System.Console.WriteLine(number1.ShowBalance());
        }
    }
}