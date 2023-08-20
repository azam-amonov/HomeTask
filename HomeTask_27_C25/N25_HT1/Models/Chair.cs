namespace HomeTask_27_C25.N25_HT1.Models;

public class Chair: IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public decimal Price { get; set; }
    public int MaxWeight { get; set; }
    public string Material { get; set; }

    public Chair(int id, string name, string description, bool isOrdered, decimal price, int maxWeight, string material)
    {
        Id = id;
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        MaxWeight = maxWeight;
        Material = material;
    }
}