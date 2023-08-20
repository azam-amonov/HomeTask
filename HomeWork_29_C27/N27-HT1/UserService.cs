namespace HomeWork_29_C27.N27_HT1;

public class UserService
{
    private List<User> _users;

    public UserService()
    {
        _users = new List<User>();
        EnsureAdminExists();
    }

    public void AddUser(User user)
    {
        var validName = Validator.IsValidName(user.FullName);
        var validEmail = Validator.IsValidEmail(user.Email);
        var validPassword = Validator.IsValidPassword(user.Password);
        
        if (!validName)
            throw new Exception("Dear User Your name is not valid! Example: 'John Smith'");
        
        if (!validEmail || _users.Any(u => u.Email.Equals(user.Email)))
            throw new Exception($"Dear User With Id: {user.Id} Your email is not valid or already in use!");
        
        if (!validPassword)
            throw new Exception("Dear User Your password is not valid or not secure enough!");
        
        _users.Add(user);
    }

    public void GetUser()
    {
        _users.ForEach(Console.WriteLine);
    }

    private void EnsureAdminExists()
    {
        var hasAdmin = _users.Any(user => user.IsAdmin);
        if (!hasAdmin)
        {
            // var newAdmin = _users.FirstOrDefault(user => !user.IsAdmin);
            // if (newAdmin != null)
            //     newAdmin.IsAdmin = true;

            var admin = new User
            {
                Id = 0,
                FullName = "Admin",
                Email = "admin@example.com",
                Password = "password123Example",
                IsAdmin = true
            };
            _users.Add(admin);
        }

    }

  
}