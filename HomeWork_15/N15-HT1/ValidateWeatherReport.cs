namespace HomeWork_15.N15_HT1;
#region Tasks
/*
- ValidatedWeahterReport service dan foydalaning, WeatherReport dan vorislik olgan bo'lsin
- unda Add methodini override qiling - kiritilgan ob-havo sana bo'yicha yo'qligini tekshiring
- agar bor bo'lsa, o'sha ob-havoni o'zgartiring, bo'lmasa yangisini qo'shing
- object yaratib, 6 ta ob-havo ma'lumotini qo'shing ( 2 tasi sanasi bir xil bo'lsin )
 */
#endregion

#region Logic
/// <summary>
/// WeatherReport calssdan vorislik olaman
/// Add methodini override qilaman -> u weater datani foreach yordamida aylandi agar ma'lumot bor bo'lsa uni yangilaydi
/// aks holda uni qo'shadi
/// Constructor orqali 6 ta yangi data qo'shaman
/// Datalar private dictionary-da saqlanadi
/// </summary>
#endregion
public class ValidateWeatherReport: WeatherReports
{
    public override string AddWeatherData(WeatherDataModel weatherDataModel)
    {
        //base.AddWeatherData(weatherDataModel);
        var modelcha = _weatherData.Values.FirstOrDefault(w => 
                        weatherDataModel.Date == w.Date && w.Location == weatherDataModel.Location);
        if (modelcha is not null)
        {
            modelcha = weatherDataModel;
            return "Updated weather data";
        }
        else
        {
            _weatherData[weatherDataModel.Location] = weatherDataModel;
        }

        return "New data added";
    }

    public override string GetWeatherData(int weather)
    {
       return base.GetWeatherData(weather);
        
    }
}