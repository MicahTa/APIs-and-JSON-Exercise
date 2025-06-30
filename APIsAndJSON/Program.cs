using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace APIsAndJSON

{
    public class Program
    {

        static void Main(string[] args)
        {
            for (int _ = 0; _ < 5; _++)
            {
                Console.WriteLine($"Ron: {RonVSKanyeAPI.GetRonQuote()}");
                Console.WriteLine($"Kanye {RonVSKanyeAPI.GetKanyeQuote()}");
            }

            Console.Write("\n\n\n\nWeather Finder");
            while (true) {
                Console.Write("What town are you in: ");
                string town = Console.ReadLine();
                Console.Write("What state are you in: ");
                string state = Console.ReadLine();
                Console.Write("What country are you in: ");
                string country = Console.ReadLine();

                string data = WeatherAPI.GetWeather(town, state, country, "af2f5d956d16e9da94e2a6ab051db5bf");
                Console.WriteLine(data);
            }
        }
    }
}
