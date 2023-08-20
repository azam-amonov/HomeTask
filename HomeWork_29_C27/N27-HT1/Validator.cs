using System.Text.RegularExpressions;

namespace HomeWork_29_C27.N27_HT1;

public static class Validator
{
    private const string NameRegex = @"^[A-Za-z ]{2,30}$";
    private const string EmailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    private const string PasswordRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

    public static bool IsValidName(string name)
    {
        return !string.IsNullOrEmpty(name) && Regex.IsMatch(name,NameRegex);
    }

    public static bool IsValidEmail(string email)
    {
        return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email,EmailRegex);
    }

    public static bool IsValidPassword(string password)
    {
        return !string.IsNullOrWhiteSpace(password) && Regex.IsMatch(password,PasswordRegex);
    }
}