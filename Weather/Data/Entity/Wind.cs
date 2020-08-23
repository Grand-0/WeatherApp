using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Wind
    {
        [JsonProperty("speed")]
        public decimal Speed { get; set; }
    }
}
