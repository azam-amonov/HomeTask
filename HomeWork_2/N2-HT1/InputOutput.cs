namespace HomeWork_2.N2_HT1;

public class InputOutput
{
    public void NameAge(string firstName, string lastName, int age)
    {
        // Console.Write("Enter your first name: ");
        // var name = Console.ReadLine();
        //
        // Console.Write("Enter your last name: ");
        // var lastName = Console.ReadLine();
        //
        // Console.Write("Enter your age: ");
        // var age = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"FirstName: {firstName} \n" +
                      $"LastName:{lastName} \n" +
                      $"Age: {age}\n");
    }

    public void CurrentDataType()
    {
        DateTime today = DateTime.Now;
        DateTime dateOnly = DateTime.Now.AddYears(-27);
        int age = 23;
        string nickname = "Max Developer!";
        
        
        Console.WriteLine(today.Date);
        Console.WriteLine($"{dateOnly.Year} yil, {dateOnly.Day} = {dateOnly.Month}");
        Console.WriteLine($"{age}- yosh");
        Console.WriteLine($"{nickname}\n");

    }

    public void CurrentType()
    {
        var primitive = "Hello, world!";
        var complex = DateTime.Now;

        var value = 23;
        var reference = "String";

        Console.WriteLine($"Primitive: {primitive}");
        Console.WriteLine($"Complex: {complex}");
        Console.WriteLine($"Value: {value}");
        Console.WriteLine($"Reference: {reference}\n");
    }
    
    
}