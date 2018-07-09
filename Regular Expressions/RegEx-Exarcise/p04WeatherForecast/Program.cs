using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)(?=\|)";
            Regex regex = new Regex(pattern);
            Dictionary<string, Forecast> forecasts = new Dictionary<string, Forecast>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (regex.IsMatch(command))
                {
                    var forecast = regex.Match(command);
                    string town = forecast.Groups[1].Value;
                    string typeOfWeather = forecast.Groups[3].Value;
                    double temperature = double.Parse(forecast.Groups[2].Value);

                    if (forecasts.ContainsKey(town)==false)
                    {
                        Forecast currentForecast = new Forecast(typeOfWeather, temperature);
                        forecasts.Add(town, currentForecast);
                    }
                    else
                    {

                        forecasts[town].TypeOfWeather = typeOfWeather;
                        forecasts[town].Temperature = temperature;
                    }
                }

            }

            foreach (var pair in forecasts.OrderBy(x=>x.Value.Temperature))
            {
                Console.WriteLine($"{pair.Key} => {pair.Value.Temperature:f2} => {pair.Value.TypeOfWeather}");
            }
        }

        class Forecast
        {
            public Forecast(string typeOfWeather, double temperature)
            {
                this.TypeOfWeather = typeOfWeather;
                this.Temperature = temperature;
            }

            public string TypeOfWeather { get; set; }
            public double Temperature { get; set; }
        }
    }
}
