using System.Text.RegularExpressions;

namespace HT_10;

public class Validator
{
    private Regex _firstName = new Regex(@"^[A-Z][a-z]*$");
    private Regex _lastName = new Regex(@"^[A-Z][a-z]*$");
    private Regex _email = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
    private Regex _phone = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
    
    public bool IsValidAge(int age)
    {
        if (age is >= 1 and <= 100)
            return true;
        return false;
    }

    public bool IsValidFirstName(string firstName)
    {
        return _firstName.IsMatch(firstName);
    }

    public bool IsValidLastName(string lastName)
    {
        return _lastName.IsMatch(lastName);
    }

    public bool IsValidEmail(string email)
    {
        return _email.IsMatch(email);
    }

    public bool IsValidPhoneNumber(string phoneNumber)
    {
        return _phone.IsMatch(phoneNumber);
    }

    public void Check()
    {
        Console.Write("Enter First Name : ");
        Console.WriteLine(IsValidFirstName(Console.ReadLine()));
        
        Console.Write("Enter Last Name : ");
        Console.WriteLine(IsValidLastName(Console.ReadLine()));

        Console.Write("Enter age: ");
        Console.WriteLine(IsValidAge(int.Parse(Console.ReadLine())));
        
        Console.Write("Enter Email: ");
        Console.WriteLine(IsValidEmail(Console.ReadLine()));
        
        Console.Write("Enter Phone Number: ");
        Console.WriteLine(IsValidPhoneNumber(Console.ReadLine()));

    }
}