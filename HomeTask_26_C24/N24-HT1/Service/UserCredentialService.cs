using System.Text.RegularExpressions;

namespace HomeTask_26_C24.N24_HT1.Service;

public class UserCredentialService : IUserCredentialService
{
    private readonly List<UserCredential> _userCredential;
    private const string PasswordRegex = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
    public UserCredentialService() => _userCredential = new List<UserCredential>();

    public UserCredential Add(Guid userId, string userPassword)
    {
        if (Regex.IsMatch(userPassword, PasswordRegex))
        {
            var userCredential = new UserCredential(userPassword, userId);
            _userCredential.Add(userCredential);
            return userCredential;
        }
        throw new Exception("Password is not valid");
    }

    public UserCredential? GetById(Guid id)
    {
        return _userCredential.Any(uc => uc.Id == id)
                        ? _userCredential.Find(uc => uc.Id == id)
                        : null;
    }
}