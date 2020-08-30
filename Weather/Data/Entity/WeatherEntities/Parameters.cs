using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Parameters
    {
        [JsonProperty("temp")]
        public float TempInKelvin { get; set; }

        [JsonProperty("feels_like")]
        public float FeelsLikeInKelvin { get; set; }

        [JsonProperty("pressure")]
        public float Pressure { get; set; }

        [JsonProperty("humidity")]
        public float Humidity { get; set; }
    }
}
