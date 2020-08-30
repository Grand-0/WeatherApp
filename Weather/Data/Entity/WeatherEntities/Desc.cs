using Newtonsoft.Json;

namespace WeatherAppWPF.Data.Entity.WeatherEntities
{
    public class Desc
    {
        [JsonProperty("main")]
        public string Description { get; set; }
        [JsonProperty("description")]
        public string LongDescription { get; set; }
    }
}
