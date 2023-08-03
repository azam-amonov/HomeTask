namespace HomeWork_17.HomeTask_1;

public sealed class Audi: CarRental
{
   public string ModelName {get; private set; }
   public decimal RentPricePerHour { get; private set; }

   public Audi(string modelName): base("Audi")
   {
      ModelName = modelName;
      RentPricePerHour = 20;
   }
}