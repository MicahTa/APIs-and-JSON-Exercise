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
        }
    }
}
