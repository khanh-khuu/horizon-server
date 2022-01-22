using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace horizon_server.Data
{
    public class WeatherForecastService
    {
        private static readonly string API_URL = "http://api.weatherapi.com/v1/forecast.json?key=dce3d8881bf34be99b384959222201&q=Binh Duong&days=10&aqi=no&alerts=no"; 
        
        public  async Task<WeatherForecast> GetForecastAsync()
        {
            HttpClient client = new HttpClient();
            
            var response = await client.GetAsync(API_URL);

            var content = await response.Content.ReadAsStringAsync();

            var json = JsonSerializer.Deserialize<WeatherForecast>(content);

            return json;
        }
    }
}
