using BlazorShared.Contracts;
using BlazorShared.Models;
using System.Net.Http.Json;

namespace BlazorWASM.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient http;

        public WeatherForecastService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<WeatherForecast[]?> GetForecastAsync(DateTime startDate)
        {
            return await http.GetFromJsonAsync<WeatherForecast[]>(
                "sample-data/weather.json");
        }
    }
}