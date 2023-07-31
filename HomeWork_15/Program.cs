// See https://aka.ms/new-console-template for more information

using HomeWork_15.N15_HT1;
#region  Birinchi ota klass 
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

// var s = weatherReports.GetWeatherData(3);
// Console.WriteLine(s);


#endregion
WeatherReports weatherReports = new WeatherReports();


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
Console.WriteLine(x);

var xxx = validateWeatherReport.AddWeatherData(new WeatherDataModel 
{
                Date = new DateOnly(2023,07,23),
                Location = "Bukhara",
                Temperature = 38,
                WeatherDescription = "Clear",
                WindSpeed = 7,
                Humidity = 5
});
Console.WriteLine(xxx);
var g = validateWeatherReport.AddWeatherData(new WeatherDataModel 
{
                Date = new DateOnly(2023,07,3),
                Location = "New York",
                Temperature = 38,
                WeatherDescription = "Clear",
                WindSpeed = 7,
                Humidity = 5
});
var c = validateWeatherReport.GetWeatherData(3);

Console.WriteLine(g);
Console.WriteLine(c);


#endregion 


