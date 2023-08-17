namespace HomeTask_26_C24.N24_HT1.Service;

public class RegistrationService
{
    private readonly IUserService _userService;
    private readonly IUserCredentialService _userCredentialService;

    public RegistrationService(IUserService userService, IUserCredentialService userCredentialService)
    {
        _userService = userService;
        _userCredentialService = userCredentialService;
    }
    

    public bool Register(string firstName, string lastName, string emailAddress, string password)
    {
        try
        {
            var user = _userService.Add(firstName, lastName, emailAddress);
            _userCredentialService.Add(user.UserId, password);
            return true;
        }
        catch
        {
            return false;
        }
    }
}