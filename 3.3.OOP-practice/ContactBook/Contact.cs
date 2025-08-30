// This program has to show a list of contacts with private atributes.
// Practive of OOP and Encapsulation.
using System;
using System.Linq;
internal class Contact
{

    private string _name;
    private string _phoneNumber;
    private string _email;

    public Guid Id { get; set; }
    public string Name
    {
        get => value;
        set
        {
            if (!value.IsNullOrEmpty)
            {
                _name = value;
            }
            else
            {
                throw new ExceptionType("The name cannot be an empty field.");
            }
        }
    }

    public string PhoneNumber
    {
        get => value;
        set
        {

            if (value.IsNullOrEmpty)
            {
                throw new ExceptionType("The phone number cannot be an empty field.");

            }
            else if (value.Any(Char.IsLetter))
            {
                throw new ExceptionType("There cannot be any letters in a phone number.");
            }
            else
            {
                _phoneNumber = value;
            }

        }
    }

    public string Email
    {
        get => value;
        set
        {
            if (!value.IsNullOrEmpty)
            {
                _email = value;
            }
            else
            {
                throw new ExceptionType("The email cannot be an empty field.");
            }
        }
    }

    public Contact(string name, string phoneNumber, string email)
    {
        Id = Guid.NewGuid;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void showContact()
    {
        System.Console.WriteLine(
            "Id: " + Id + "\n" +
            "Name: " + Name + "\n" +
            "Phone Number: " + PhoneNumber + "\n" +
            "E-mail: " + Email + "\n"
        );
    }
    public void UpdatePhoneNumber(string newPhoneNumber)
    {
        if (newPhoneNumber.IsNullOrEmpty)
        {
            throw new ExceptionType("The phone number cannot be an empty field.");

        }
        else if (newPhoneNumber.Any(Char.IsLetter))
        {
            throw new ExceptionType("There cannot be any letters in a phone number.");
        }
        else
        {
            PhoneNumber = newPhoneNumber;
        }
    }
    
    public void UpdateEmail(string newEmail)
    {
        if (newEmail.IsNullOrEmpty)
        {
            throw new ExceptionType("The phone number cannot be an empty field.");

        }
        else if (!newEmail.Contains("@")) {
            throw new ExceptionType("This is not a valid e-mail.");
        }
        else
        {
            Email = newEmail;
        }
    }
    
}

