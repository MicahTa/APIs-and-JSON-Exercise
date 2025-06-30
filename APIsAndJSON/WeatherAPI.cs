using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Net.Http;
using System.Text.Json;
static class WeatherAPI
{

    public static string GetWeather(string cityName, string stateCode, string countryCode, string APIKey)
    {
        string APILink = $"https://api.openweathermap.org/data/2.5/weather?q={cityName},{stateCode},{countryCode}&appid={APIKey}&units=imperial";

        var client = new HttpClient();
        string apiResponse = client.GetStringAsync(APILink).Result;

        // Parse the JSON
        using JsonDocument doc = JsonDocument.Parse(apiResponse);
        JsonElement root = doc.RootElement;

        // Extract temperature and weather description
        double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
        string description = root.GetProperty("weather")[0].GetProperty("description").GetString();
        string city = root.GetProperty("name").GetString();

        return $"In {city}, it is {temp}°F with {description}.";
    }

}