namespace HomeWork_13.OwnPractic_Inheret.Vehicle_Classes;

public class Car: VehicleModel
{
    public string CarName { get; set; }
    public string CarMake { get; set; }
    public int CarSpeed { get; set; }
    
    public Car(string name, string make) : base(name)
    {
        CarName = name;
        CarMake = make;
    }

    public Car(string name, string make, int speed) : this(name, make)
    {
        CarSpeed = speed;
    }

    public override string ToString()
    {
        return $"Name: {CarName} \nMake: {CarMake} \nSpeed: {CarSpeed}";
    }

    public new void Move()
    {
        Console.WriteLine("Im Driving");
    }
}