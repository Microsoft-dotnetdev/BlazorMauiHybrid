using BlazorShared.Models;


namespace BlazorShared.Contracts
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]?> GetForecastAsync(DateTime startDate);
    }
}
