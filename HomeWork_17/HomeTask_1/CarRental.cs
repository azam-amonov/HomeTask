namespace HomeWork_17.HomeTask_1;

public abstract class CarRental
{
    // public List<CarRental> _carRentals = new List<CarRental>();
    public int Id
    {
        get;
        set;
    }
    public bool IsRented { get; set; }
    public decimal Balance { get; set; }
    public string BrandName { get; set; }
    public DateTime RentStartTime { get; set; }

    protected CarRental(string brandName)
    {
        Balance = 0;
        IsRented = false;
        BrandName = brandName;
        RentStartTime = DateTime.MinValue;
    }
    



}