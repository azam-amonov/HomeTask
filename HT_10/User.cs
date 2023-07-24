namespace HT_10;


public class User
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    int Age { get; set; }

    public User GetInfo()
    {
        Console.Write("Enter first name: ");
        string? firstName = Console.ReadLine(); 

        Console.Write("Enter last name: ");
        string? lastName = Console.ReadLine();
        int age;
        while (true)
        {
            try
            {
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Enter a latter not a number!");
            }
        }

        return new User
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age
        };

    }
    public void Display(User user)
    {
        Console.WriteLine();
        Console.WriteLine($"First name: {user.FirstName}\n" +
                          $"Last name: {user.LastName}\n" +
                          $"Age:{user.Age}");
    }

}
