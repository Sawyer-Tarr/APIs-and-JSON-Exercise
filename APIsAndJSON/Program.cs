using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();

            //var kanyeURL = "https://api.kanye.rest";


            //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            //Console.WriteLine();
            //Console.WriteLine($"Kanye: '{kanyeQuote}'");


            //var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //var ronResponse = client.GetStringAsync(ronURL).Result;

            //var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"',' ').Replace('"',' ').Trim();
            //Console.WriteLine();
            //Console.WriteLine($"Ron: '{ronQuote}'");

            for (int i = 0; i <= 4; i++)
            {
                RonAndKanye.Kanye();
                Console.WriteLine();
                RonAndKanye.Ron();
                Console.WriteLine();
            }
        }
    }
}
