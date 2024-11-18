using System.Text.Json.Serialization;

namespace GloboClima.WebApp.Models
{
    public class CoordenatesModel
    {
        [JsonPropertyName("lon")]
        public double longitude { get; set; }

        [JsonPropertyName("lat")]
        public double latitude { get; set; }
    }
}
