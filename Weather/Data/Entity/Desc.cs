using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Desc
    {
        [JsonProperty("main")]
        public string State { get; set; }

        [JsonProperty("description")]
        public string WeatherDescription { get; set; }
    }
}
