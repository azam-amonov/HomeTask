namespace HomeWork_15.N15_HT1;

public class WeatherDataModel
{
    public DateOnly Date { get; set; }
    public string Location { get; set; }
    public int Temperature { get; set; }
    public string WeatherDescription { get; set; }
    public int WindSpeed { get; set; }
    public int Humidity { get; set; }

    public WeatherDataModel(DateOnly date = default, string location = null,
                    int temperature = 0, string weatherDescription = null, int windSpeed = 0, int humidity = 0)
    {
        Date = date;
        Location = location;
        Temperature = temperature;
        WeatherDescription = weatherDescription;
        WindSpeed = windSpeed;
        Humidity = humidity;
    }

    public override string ToString()
    {
        return $"Date: {Date}\n" +
               $"Location: {Location}\n" +
               $"Temperature: {Temperature}˚C\n" +
               $"WeatherDescription: {WeatherDescription}\n" +
               $"WindSpeed: {WindSpeed} ≈\n" +
               $"Humidity: {Humidity} %\n";
    }
}