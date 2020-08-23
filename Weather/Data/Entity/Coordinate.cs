using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Coordinate
    {
        [JsonProperty("lon")]
        public string Longitude { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }
    }
}
