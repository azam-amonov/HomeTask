namespace HomeWork_25_C23.N23_HT2;

public class UserService
{
    private List<User> _users;

    public UserService()
    {
        _users = new List<User>
        {
            new User("John", "Doe", "johndoe@example.com"),
            new User("Jane", "Doe", "janedoe@example.com"),
            new User("Bob", "Smith", "bobsmith@example.com"),
            new User("Alice", "Johnson", "alicejohnson@example.com"),
            new User("Mike", "Brown", "mikebrown@example.com"),
            new User("Emily", "Davis", "emilydavis@example.com"),
            new User("David", "Wilson", "davidwilson@example.com"),
            new User("Sarah", "Taylor", "sarahtaylor@example.com"),
            new User("Tom", "Anderson", "tomanderson@example.com"),
            new User("Lisa", "Thomas", "lisathomas@example.com")

        };
    }

    public void Display(string keyword)
    {
        var data = _users
                        .Where(x => x.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                        x.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                        x.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                        ).ToList();

        foreach (var user in data)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} {user.Email}");
        }
    }
}