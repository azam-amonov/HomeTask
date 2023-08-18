namespace HomeTask_26_C24.N24_HT1;

public class UserCredential
{
    public Guid Id {get; set; }
    public string Password {get; set; }
    public Guid UserId { get; set; }

    public UserCredential(string password, Guid userId)
    {
        Id = Guid.NewGuid();
        Password = password;
        UserId = userId;
    }
}