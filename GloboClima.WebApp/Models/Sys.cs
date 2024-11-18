using System.Text.Json.Serialization;

namespace GloboClima.WebApp.Models
{
    public class Sys
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("sunrise")]
        public int Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public int Sunset { get; set; }
    }
}
