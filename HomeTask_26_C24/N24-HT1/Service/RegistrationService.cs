namespace HomeTask_26_C24.N24_HT1.Service;

public class RegistrationService
{
    private IUserService _userService;
    private IUserCredentialService _userCredentialService;
    private List<User> _users;

    public RegistrationService(IUserService userService, IUserCredentialService userCredentialService)
    {
        _userService = userService;
        _userCredentialService = userCredentialService;
        _users = new List<User>();
    }
    

    public void Register(string firstName, string lastName, string emailAddress, string password)
    {
        _userService.Add(firstName, lastName, emailAddress);
        _userCredentialService.Add(1, password);
    }
}