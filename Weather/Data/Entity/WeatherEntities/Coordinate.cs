using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Coordinate
    {
        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }
    }
}
