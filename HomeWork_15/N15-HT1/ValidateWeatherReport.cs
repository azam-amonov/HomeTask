namespace HomeWork_15.N15_HT1;
#region Tasks
/*
- ValidatedWeahterReport service dan foydalaning, WeatherReport dan vorislik olgan bo'lsin
- unda Add methodini override qiling - kiritilgan ob-havo sana bo'yicha yo'qligini tekshiring
- agar bor bo'lsa, o'sha ob-havoni o'zgartiring, bo'lmasa yangisini qo'shing
- object yaratib, 6 ta ob-havo ma'lumotini qo'shing ( 2 tasi sanasi bir xil bo'lsin )
 */
#endregion


using System;
using System.Collections.Generic;
using System.Linq;

public class ValidateWeatherReport : WeatherReports
{
    private List<WeatherDataModel> _weatherData = new List<WeatherDataModel>();

    public override string AddWeatherData(WeatherDataModel weatherDataModel)
    {
        var existingData = _weatherData.FirstOrDefault(w 
                        => w.Date.Day == weatherDataModel.Date.Day && w.Location == weatherDataModel.Location);

        if (existingData != null)
        {
            existingData.Humidity = weatherDataModel.Humidity;
            existingData.WindSpeed = weatherDataModel.WindSpeed;
            existingData.Temperature = weatherDataModel.Temperature;
            existingData.WeatherDescription = weatherDataModel.WeatherDescription;
            Console.WriteLine($"{existingData.Date} sanadagi {existingData.Location} uchun ma'lumoti yangilandi!");
        }
        else
        {
            _weatherData.Add(weatherDataModel);
            Console.WriteLine("Yangi ma'lumot qo'shildi");
        }

        return "Success!";
    }

    private WeatherDataModel FindWeatherData(int weatherDate)
    {
        foreach (var w in _weatherData)
        {
            if (w.Date.Day == weatherDate)
                return w;
        }
        return null;
    }

    public override string GetWeatherData(int weatherDate)
    {
        var resWeather = FindWeatherData(weatherDate);
        if (resWeather is null)
            return "Bu kunda ma'lumot topilmadi!";
        else
            return resWeather.ToString();
    }


}
