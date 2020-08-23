using Newtonsoft.Json;

namespace Weather.Entity
{
    public class City
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
