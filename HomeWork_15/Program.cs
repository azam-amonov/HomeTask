// See https://aka.ms/new-console-template for more information

using HomeWork_15.N15_HT1;
#region  Birinchi ota klass 
// WeatherReports weatherReports = new WeatherReports();
//
// weatherReports.AddWeatherData
// (new WeatherDataModel
// {
//                 Date = new DateOnly(2023,07,31),
//                 Location = "Tashkent",
//                 Temperature = 38,
//                 WeatherDescription = "Clear",
//                 WindSpeed = 7,
//                 Humidity = 5
// });
//
// var s = weatherReports.GetWeatherData(31);
// Console.WriteLine(s);


#endregion

#region Ikkinchi klass
ValidateWeatherReport validateWeatherReport = new ValidateWeatherReport();

var x = validateWeatherReport.AddWeatherData(new WeatherDataModel 
{
                Date = new DateOnly(2023,07,23),
                Location = "Bukhara",
                Temperature = 38,
                WeatherDescription = "Clear",
                WindSpeed = 7,
                Humidity = 5
});

var xxx = validateWeatherReport.AddWeatherData(new WeatherDataModel 
{
                Date = new DateOnly(2023,07,23),
                Location = "Bukhara",
                Temperature = 38,
                WeatherDescription = "Clear",
                WindSpeed = 7,
                Humidity = 5
});

var t = validateWeatherReport.GetWeatherData(23);
Console.WriteLine(t);

#endregion 


