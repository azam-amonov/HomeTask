using System.Text.RegularExpressions;

namespace HomeWork_19.N19_HT1_in_out;

public static class ValidatorService
{
    private const string NameValidRegex = @"^[A-Za-z]{3,15}$";
    private const string PhoneNumberValidRegex = @"^\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$";
    private const string EmailAddressValidRegex = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
    
    
    public static bool IsValidAge(in int age)
    {
        if (age is > 0 and < 100)
            return true;
        return false;
    }

    public static bool IsValidName(in string name, out string fixedNameFormat)
    {
        fixedNameFormat = string.Empty;
        if (string.IsNullOrWhiteSpace(name))
            return false;
        
        fixedNameFormat = name.Trim();
        if (Regex.IsMatch(fixedNameFormat, NameValidRegex))
            return true;
        
        return false;
    }

    public static bool IsValidPhoneNumber(in string phoneNumber, out string fixedPhoneNumber)
    {
        fixedPhoneNumber = string.Empty;
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;
        
        fixedPhoneNumber = phoneNumber.Trim();
        
        if(Regex.IsMatch(fixedPhoneNumber, PhoneNumberValidRegex))
            return true;
        return false;
    }

    public static bool IsValidEmailAddress(in string emailAddress, out string fixedEmailAddress)
    {
        fixedEmailAddress = string.Empty;
        
        if (string.IsNullOrWhiteSpace(emailAddress))
            return false;
        
        fixedEmailAddress = emailAddress.Trim();
        
        if(Regex.IsMatch(fixedEmailAddress, EmailAddressValidRegex))
            return true;
        return false;
    }
}