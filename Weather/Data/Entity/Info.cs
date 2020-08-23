using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Info
    {
        [JsonProperty("id")]
        public int CountryId { get; set; }
        [JsonProperty("country")]
        public string CountryName { get; set; }
    }
}
