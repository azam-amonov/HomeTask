namespace HomeWork_16.N16_HT1;

#region Tasks
/*
- Spaceship modelidan foydalaning unda quyidagi propertylar bo'lsin
- Name - nomi ( init-only )
- Fuel - yoqilg'i miqdori ( read-only )
- Speed - tezligi ( read-write )
- Trajectory - trayektoriyasi ( write-only )
- bitta object yarating, speed va trajectory ni har xil qiymatlarga o'zgartirib ekranga chiqaring
 */
#endregion

public class SpaceShip
{
    private string _trajectory;
    
    public string Name { get; init; }
    public int Fuel { get; }
    public int Speed { get; set; }
    public string Trajectory
    {
        get => _trajectory;
        set =>  _trajectory = value;
    }

    public SpaceShip(string name, int fuel, int speed, string trajectory)
    {
        Name = name;
        Fuel = fuel;
        Speed = speed;
        Trajectory = trajectory;
    }
    

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Fuel: {Fuel} L\n" +
               $"Speed: {Speed} km/m \n" +
               $"Trajectory: {Trajectory}\n";
    }
}