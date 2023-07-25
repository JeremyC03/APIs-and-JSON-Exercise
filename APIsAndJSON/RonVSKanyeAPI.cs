using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void RonQuote()
        {
            HttpClient client = new HttpClient();
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(ronURL).Result;
            JArray ronQuote = JArray.Parse(ronResponse);
            Console.WriteLine($"Ron: {ronQuote[0]}");
            Console.WriteLine();
        }

        public static void KanyeQuote()
        {
            HttpClient client = new HttpClient();
            string kanyeURL = "https://api.kanye.rest/";
            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine();
        }

    }
}
