namespace HomeWork_13.OwnPractic_Inheret.Vehicle_Classes;

public class VehicleModel
{
    public string Name { get; set; }

    public VehicleModel(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine("I'm moving!");
    }

    public void Stop()
    {
        Console.WriteLine("I stopped!");
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}


