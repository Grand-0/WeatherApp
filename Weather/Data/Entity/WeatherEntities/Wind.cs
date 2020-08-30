using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Wind
    {
        [JsonProperty("speed")]
        public float Speed { get; set; }
    }
}
