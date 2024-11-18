using System.Text.Json.Serialization;

namespace GloboClima.WebApp.Models
{
    public class ForecastModel
    {
        [JsonPropertyName("coord")]
        public CoordenatesModel Coord { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherModel> Weather { get; set; }

        public string Base { get; set; }

        [JsonPropertyName("main")]
        public MainModel Main { get; set; }

        [JsonPropertyName("visibility")]
        public long Visibility { get; set; }

        [JsonPropertyName("wind")]
        public WindModel Wind { get; set; }

        [JsonPropertyName("clouds")]
        public CloudsModel Clouds { get; set; }

        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }

        [JsonPropertyName("timezone")]
        public long TimeZone { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cod")]
        public int Cod { get; set; }

    }
}
