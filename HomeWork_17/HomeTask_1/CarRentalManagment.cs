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
        foreach (var c in _cars)
        {
            if (c.Id == car.Id)
            {
                car.IsRented = false;
                var rentDuration = (int)(DateTime.Now - car.RentStartTime).TotalSeconds;
                var rentPrice = (car is Bmw) ? (car as Bmw).RentPricePerHour : (car as Audi).RentPricePerHour;
                car.Balance = rentDuration * rentPrice;
            }
            else
            {
                Console.WriteLine($"Couldn't find car with Id {car}");
            }
        }
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

    public void Display()
    {
        foreach (var car in _cars)
        {
            Console.WriteLine($"{car.Id}\n" +
                              $"{car.BrandName}\n");
        }
    }
}