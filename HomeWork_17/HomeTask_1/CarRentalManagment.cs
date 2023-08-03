namespace HomeWork_17.HomeTask_1;

public class CarRentalManagement
{
    public List<CarRental> _cars {get; set; }

    public CarRentalManagement()
    {
        _cars = new List<CarRental>();
    }
    
    public void AddCar(CarRental car)
    {
        _cars.Add(car);
    }

    public CarRental RentCar(string brandName)
    {
        foreach (var c in _cars)
        {
            if (c.BrandName == brandName)
            {
                c.IsRented = true;
                c.RentStartTime = DateTime.Now;
                return c;
            }
        }
        Console.WriteLine($"Couldn't find car with brand {brandName}");
        return null;
    }

    public void ReturnCar(CarRental car)
    {
        car.IsRented = false;
        var rentDuration = (int)(DateTime.Now - car.RentStartTime).TotalSeconds;
        var rentPrice = (car is Bmw) ? (car as Bmw).RentPricePerHour : (car as Audi).RentPricePerHour;
        car.Balance = rentDuration * rentPrice;
    }

    public decimal CalculateManagement()
    {
        decimal totalBalance = 0;
        foreach (var car in _cars)
        {
            totalBalance += (decimal)car.Balance;
        }
        return totalBalance;
    }
}