
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static string GetKanyeQuote()
        {
            var client = new HttpClient();
            string kanye = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanye).Result;

            var kanyeQuote = JsonObject.Parse(kanyeResponse)["quote"].ToString();

            return $"\"{kanyeQuote}\"";
        }

        public static string GetRonQuote()
        {
            var client = new HttpClient();
            string ron = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ron).Result;
            var ronQuote = JsonArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }
    }
}
