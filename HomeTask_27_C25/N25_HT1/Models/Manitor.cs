namespace HomeTask_27_C25.N25_HT1.Models;

public class Manitor: IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public decimal Price { get; set; }
    public double DisplaySize { get; set; }
    public int RefreshRate { get; set; }

    public Manitor(int id, string name, string description, bool isOrdered, decimal price, double displaySize, int refreshRate)
    {
        Id = id;
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        DisplaySize = displaySize;
        RefreshRate = refreshRate;
    }
}
