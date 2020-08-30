using Newtonsoft.Json;
using System.Collections.Generic;
using Weather.Entity;
using WeatherAppWPF.Data.Entity.WeatherEntities;

namespace Weather.Data
{
    public class WeatherModel
    {
        [JsonProperty("coord")]
        public Coordinate coordinate { get; set; } // +
        [JsonProperty("weather")]
        public List<Desc> descriptions { get; set; }  // +
        [JsonProperty("name")]
        public string cityName { get; set; } // +
        [JsonProperty("main")]
        public Parameters parameters { get; set; } // +
        [JsonProperty("sys")]
        public Info info { get; set; } // +

        [JsonProperty("wind")]
        public Wind wind { get; set; } // +
    }
}
