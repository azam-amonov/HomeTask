namespace HomeWork_29_C27.N27_HT1;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }

    public User()
    {
        
    }

    public User(int id, string email, string fullName, string password, bool isAdmin = false)
    {
        Id = id;
        Email = email;
        FullName = fullName;
        Password = password;
        IsAdmin = isAdmin;
    }
    

    public override string ToString()
    {
        return $"{Id} {Email} {FullName} {Password} {IsAdmin}";
    }
}