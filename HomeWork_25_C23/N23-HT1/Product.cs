namespace HomeWork_25_C23.N23_HT1;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint Star { get; set; }
    public int Inventory {get; set; }

    public Product(int id, string name, uint star, int inventory)
    {
        Id = id;
        Name = name;
        Star = star;
        Inventory = inventory;
    }
}