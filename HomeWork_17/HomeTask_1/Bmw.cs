namespace HomeWork_17.HomeTask_1;

public sealed class Bmw: CarRental
{
  
    public string ModelName { get; private set; }
    public decimal RentPricePerHour { get; private set; }

    public Bmw(string modelName): base("BMW")
    {
        ModelName = modelName;
        RentPricePerHour = 30;
        BrandName = "BMW";
    }
}