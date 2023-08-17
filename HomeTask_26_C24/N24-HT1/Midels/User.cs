namespace HomeTask_26_C24.N24_HT1;

public class User
{
    public Guid UserId {get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public string EmailAddress {get; set; }
    public bool IsDeleted {get; set; }

    public User(string firstName, string lastName, string emailAddress)
    {
        UserId = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        // IsDeleted = true;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {EmailAddress} {IsDeleted}";
    }
}