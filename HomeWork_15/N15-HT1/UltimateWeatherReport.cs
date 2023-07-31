namespace HomeWork_15.N15_HT1;

#region MyRegion
/*
- UltimateWeatherReport service dan foydalaning, ValidatedWeahterReport dan vorislik olgan bo'lsin
- unda Get methodi bo'lsin - berilgan sana va nechta kunligidan kelib o'sib borish tartibida ob-havo ma'lumotlarini qaytarsin
- yana bitta Get methodi bo'lsin - unda faqat nechta kun uchun ob-havo kerakligini bildiruvchi paramter bo'lsin - bugundan boshlab shuncha kun uchun ob-havo ma'lumotlarini o'sib borish tartibida qaytarsin
- o'sib borish tartibida tartiblash uchun Sort nomli private methoddan foydalaning
- ikkala Get methodida ham agar berilgan nechta kunigi bo'yicha to'liq ma'lumot bo'lmasa "Uzr, to'liq ma'lumot yo'q" ekranga chiqsin va bo'sh kolleksiya qatarilsin
- object yaratib, 10 ta ob-havo ma'lumoti qo'shing va Get methodlari orqali so'rov qilib, ekranga chiqaring
 */
#endregion

#region Logic
/*
 * 
 */
#endregion


public class UltimateWeatherReport : ValidateWeatherReport
{
    List<WeatherDataModel> _weatherData = new List<WeatherDataModel>();
    public override string AddWeatherData(WeatherDataModel weatherDataModel)
    {
        _weatherData.Add(weatherDataModel);
        return "Success";
    }

    public void Get(int days)
    {
        SortData();
        var weatherList = _weatherData.Take(days);
        foreach (var w in weatherList)
        {
            Console.WriteLine(w);
        }

    }

    public void Get(int fromDate, int days)
    {
        SortData();
        var weatherList = _weatherData.Skip(fromDate).Take(days);
        
        foreach (var w in weatherList)
        {
            Console.WriteLine(w);
        }
    }
    private void SortData()
    {
        _weatherData = _weatherData.OrderBy(obj => obj.Date).ToList();
    }

    public UltimateWeatherReport()
    {
        AddWeatherData(new WeatherDataModel
        {
                        Date = new DateOnly(2023, 08, 1),
                        Location = "Tashkent",
                        Temperature = 38,
                        WeatherDescription = "Clear",
                        WindSpeed = 7,
                        Humidity = 33
        });
        
        AddWeatherData(new WeatherDataModel
        {
                        Date = new DateOnly(2023, 07, 30),
                        Location = "Tashkent",
                        Temperature = 38,
                        WeatherDescription = "Clear",
                        WindSpeed = 7,
                        Humidity = 33
        });
        AddWeatherData(new WeatherDataModel
        {
                        Date = new DateOnly(2023, 07, 31),
                        Location = "Tashkent",
                        Temperature = 38,
                        WeatherDescription = "Clear",
                        WindSpeed = 7,
                        Humidity = 33
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 2),
            Location = "Tashkent",
            Temperature = 38,
            WeatherDescription = "Clear",
            WindSpeed = 7,
            Humidity = 33
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 3),
            Location = "New York",
            Temperature = 29,
            WeatherDescription = "Partly Cloudy",
            WindSpeed = 12,
            Humidity = 55
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 4),
            Location = "Sydney",
            Temperature = 24,
            WeatherDescription = "Rainy",
            WindSpeed = 18,
            Humidity = 80
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 5),
            Location = "London",
            Temperature = 22,
            WeatherDescription = "Overcast",
            WindSpeed = 9,
            Humidity = 70
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 6),
            Location = "Tokyo",
            Temperature = 31,
            WeatherDescription = "Sunny",
            WindSpeed = 14,
            Humidity = 50
        });
        
        AddWeatherData(new WeatherDataModel
        {
            Date = new DateOnly(2023, 08, 7),
            Location = "Cairo",
            Temperature = 42,
            WeatherDescription = "Hot and Dry",
            WindSpeed = 6,
            Humidity = 25
        });
    }
    
}

