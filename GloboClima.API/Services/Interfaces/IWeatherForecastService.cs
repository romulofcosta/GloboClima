namespace GloboClima.API.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<string> GetCityWeatherForecast(string cityName);
    }
}
