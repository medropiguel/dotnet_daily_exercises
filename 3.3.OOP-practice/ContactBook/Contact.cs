// This program has to show a list of contacts with private atributes.
// Practive of OOP and Encapsulation.
using System;
using System.Linq;
namespace Models
{
    internal class Contact
    {

        private string _name;
        private string _phoneNumber;
        private string _email;

        public Guid Id { get; private set; }
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("The name cannot be an empty field.");
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The phone number cannot be an empty field.");

                }
                else if (value.Any(Char.IsLetter))
                {
                    throw new ArgumentException("There cannot be any letters in a phone number.");
                }
                else
                {
                    _phoneNumber = value;
                }

            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("The email cannot be an empty field.");
                }
            }
        }

        public Contact(string name, string phoneNumber, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void ShowContact()
        {
            System.Console.WriteLine(
                "Id: " + Id + "\n" +
                "Name: " + Name + "\n" +
                "Phone Number: " + PhoneNumber + "\n" +
                "E-mail: " + Email + "\n"
            );
        }
        public void UpdatePhoneNumber(string newPhoneNumber) => PhoneNumber = newPhoneNumber;

        public void UpdateEmail(string newEmail) => Email = newEmail;

    }

}