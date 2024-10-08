using System.Drawing;

namespace GloboClima.API.Models
{
    public class ForecastModel
    {
        public CoordenatesModel Coord { get; set; }
        public WeatherModel Weather { get; set; }
        public string Base { get; set; }
        public MainModel main { get; set; }
        public long visibility { get; set; }
        public WindModel Wind { get; set; }
        public CloudsModel Clouds { get; set; }
        public long Dt { get; set; }
        public Sys Sys { get; set; }
        public long TimeZone { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

    }
}
