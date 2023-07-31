namespace HomeWork_15.N15_HT1;
#region Task
/*
- online ob havo dasturi tuzing
- WeatherReport service dan foydalaning
- unda Get methodi bo'lsin - berilgan sanadan kelib chiqib ob-havoni string formatda qaytarsin
- unda private Find methodi bo'lsin - agar berilgan kunga ob - havo topilmasa null qaytarsin
- Get methodida Find methodidan foydalaning agar qaytgan qiymat null bo'lsa - "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring" message chiqsin, yo'qsa ob-havoni qaytarsin
- Add ( sana, ob-havo qisqacha ) methodi qo'shing - u ob-havo kolleksiyaga qo'shib borsin
- object yaratib, 6 ta ob-havo ma'lumotini qo'shing, 2 tasini ( bitta mavjud va bitta yo'q bo'lgan ) ob-havoni so'rang va ekranga chiqaring
 */
#endregion

#region Logic
/*
 * WeatherReport nomli class ochaman privet dictionary bo'laadi key detatime va string value
 * DateTime-da sanani va string-da qanday ob-havo ekalnigini saqlaydi
 * Get method bo'laadi un datetime-da va sanani oladi va dictionary-dan ma'lumotni qaytaradi
 * Add method bo'laadi un datetime-da sanani va string-da qanday ob-havo ekalnigini kiritadi
 * Find method bo'ladi un datetime-da orlqali ma'lumotni qaytaradi agar ma'lumot bo'lmasa null qaytaradi
 */


#endregion
public class WeatherReports
{
    WeatherDataModel _wertherModel = new WeatherDataModel();
    protected List<WeatherDataModel> _weatherData = new List<WeatherDataModel>();

    
    public virtual string AddWeatherData(WeatherDataModel weatherDataModel)
    {
        _weatherData.Add(weatherDataModel);
        return "Success";
    }
   
    private WeatherDataModel FindWeatherData(int weatherDate)
    {
        foreach (var w in _weatherData)
        {
            if (w.Date.Day == weatherDate)
                return w;
        }
        return null!;
    }

    public virtual string GetWeatherData(int weather)
    {
        var resWeather = FindWeatherData(weather);
        if (resWeather is null)
            return "Bu kunda ma'lumot topilamadi";
        return resWeather.ToString();
    }
    
    
/// <summary>
///  Quyidagi constructor oldindafn data qo'shish uchun yozilgan
/// </summary>
     public WeatherReports()
     {
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 2),
         //     Location = "Tashkent",
         //     Temperature = 38,
         //     WeatherDescription = "Clear",
         //     WindSpeed = 7,
         //     Humidity = 33
         // });
         //
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 3),
         //     Location = "New York",
         //     Temperature = 29,
         //     WeatherDescription = "Partly Cloudy",
         //     WindSpeed = 12,
         //     Humidity = 55
         // });
         //
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 4),
         //     Location = "Sydney",
         //     Temperature = 24,
         //     WeatherDescription = "Rainy",
         //     WindSpeed = 18,
         //     Humidity = 80
         // });
         //
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 5),
         //     Location = "London",
         //     Temperature = 22,
         //     WeatherDescription = "Overcast",
         //     WindSpeed = 9,
         //     Humidity = 70
         // });
         //
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 6),
         //     Location = "Tokyo",
         //     Temperature = 31,
         //     WeatherDescription = "Sunny",
         //     WindSpeed = 14,
         //     Humidity = 50
         // });
         //
         // AddWeatherData(new WeatherDataModel
         // {
         //     Date = new DateOnly(2023, 08, 7),
         //     Location = "Cairo",
         //     Temperature = 42,
         //     WeatherDescription = "Hot and Dry",
         //     WindSpeed = 6,
         //     Humidity = 25
         // });
     }
}