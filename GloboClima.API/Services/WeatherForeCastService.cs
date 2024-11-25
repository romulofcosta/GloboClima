using GloboClima.API.Services.Interfaces;
using GloboClima.Core.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GloboClima.API.Services
{
    public class WeatherForeCastService : IWeatherForecastService
    {
        private const string SECTION_WEB_API = "OpenWeatherMap";
        private const string ENDPOINT = "EndpointApi";
        private const string API_KEY = "Apikey";

        private readonly IConfiguration _configuration;
        private readonly IExternalWebApiService _externalWebApiService;

        public WeatherForeCastService(IConfiguration configuration,IExternalWebApiService externalWebApiService)
        {
            _configuration = configuration;
            _externalWebApiService = externalWebApiService;    
        }

        public async Task<string> GetCityWeatherForecast(string cityName)
        {
            try
            {
                if (cityName is null) 
                    throw new Exception("Cidade não informada!");

                var endpoint = _configuration.GetSection(SECTION_WEB_API).GetValue<string>(ENDPOINT);
                var apiKey = _configuration.GetSection(SECTION_WEB_API).GetValue<string>(API_KEY);

                if (endpoint is null || apiKey is null)
                    throw new Exception("Configurações não informada!");

                endpoint = endpoint.Replace("[city]",cityName).Replace("[apikey]", apiKey);

                var res = await _externalWebApiService.GetExternalData(endpoint);

                return res.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
