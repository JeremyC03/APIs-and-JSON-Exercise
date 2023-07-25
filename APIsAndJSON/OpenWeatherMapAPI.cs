using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void WeatherMapAPI() 
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string apiKey = configuration.GetSection("AppSettings")["ApiKey"];


            HttpClient client = new HttpClient();

            Console.WriteLine("Please enter a city: ");
            var cityInput = Console.ReadLine();

            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityInput}&appid={apiKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherURL).Result;
            JObject weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine($"Current weather in {cityInput} is {weatherObject["main"]["temp"]} Fahrenheit");
        }
    }
}
