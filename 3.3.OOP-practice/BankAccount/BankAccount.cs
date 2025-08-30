using System;

namespace Model
{
    public class BankAccount
    {
        private Guid _id;
        private string _name;
        private double _balance;

        public Guid Id { get => _id; }
        public string Name { get => _name; private set => _name = value; }
        public double Balance { get => _balance; private set => _balance = value; }

        public BankAccount(string name = "", double balance = 0)
        {
            _id = Guid.NewGuid();
            Name = name;
            Balance = balance;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public string Withdraw(double value)
        {
            if ((Balance - value) < 0)
            {
                return "It is not possible to withdraw more than your current balance.";
            }
            else
            {
                Balance -= value;
                return $"Success! You now have {Balance} dollars.";
            }
        }

        public string ShowBalance()
        {
            return $"You have {Balance} dollars.";
        }
    }

}
