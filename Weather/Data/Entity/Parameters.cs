using Newtonsoft.Json;

namespace Weather.Entity
{
    public class Parameters
    {
        [JsonProperty("temp")]
        public decimal TempInKelvin { get; set; }

        [JsonProperty("feels_like")]
        public decimal FeelsLikeInKelvin { get; set; }

        [JsonProperty("pressure")]
        public decimal Pressure { get; set; }

        [JsonProperty("humidity")]
        public decimal Humidity { get; set; }
    }
}
