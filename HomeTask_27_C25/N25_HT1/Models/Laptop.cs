namespace HomeTask_27_C25.N25_HT1.Models;

public class Laptop: IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public decimal Price { get; set; }
    public string CpuBrand { get; set; }
    public string CpuModel { get; set; }

    public Laptop(int id, string name, string description, bool isOrdered, decimal price, string cpuBrand, string cpuModel)
    {
        Id = id;
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        CpuBrand = cpuBrand;
        CpuModel = cpuModel;
    }
}