using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using WeatherService.Entities;

namespace WeatherService.Implementations
{
    public class WeatherForecastImplementation
    {
        internal static async Task<WeatherForecast> GetWeatherForecast(string url, string key, int postalCode, Dictionary<int,string> summaries)
        {
            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Clear();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await httpClient.GetFromJsonAsync<WeatherBitResponse>("current?postal_code="  + postalCode + "&key=" + key);
                if(response != null && response.count > 0)
                {
                    var summary = "Unknown";
                    if (summaries.ContainsKey(response.data[0].weather.code)) summary = summaries[response.data[0].weather.code];
                    WeatherForecast forecast = new WeatherForecast()
                    {
                        date = response.data[0].datetime,
                        temprature = new Temperature() { celcius = response.data[0].temp },
                        summary = summary
                    };
                    return forecast;

                }
                else
                {
                    return null;
                }
                
            }
        }
    }
}
