using GloboClima.API.Services.Interfaces;
using GloboClima.Core.Services;
using System.Net;
using System.Text;

namespace GloboClima.API.Services
{
    public class WeatherForeCastService : IWeatherForecastService
    {
        private readonly string _sectionWebApi = "OpenWeatherMap";
        private readonly string _endpoint = "EndpointApi";
        private readonly string _apiKey = "Apikey";

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

                var endpoint = _configuration.GetSection(_sectionWebApi).GetValue<string>(_endpoint);
                var apiKey = _configuration.GetSection(_sectionWebApi).GetValue<string>(_apiKey);

                if (endpoint is null || apiKey is null)
                    throw new Exception("Configurações não informada!");

                endpoint = endpoint.Replace("[city]",cityName).Replace("[apikey]", apiKey);

                var res = await _externalWebApiService.GetExternalData(endpoint);

                return res;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
