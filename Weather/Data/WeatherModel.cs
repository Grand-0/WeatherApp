using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using Weather.Entity;

namespace Weather.Data
{
    public class WeatherModel
    {
        [JsonProperty("weather")]
        public Desc desc { get; set; }
        [JsonProperty("coord")]
        public Coordinate coordinate { get; set; }
        [JsonProperty("name")]
        public City city { get; set; }
        [JsonProperty("main")]
        public Parameters parameters { get; set; }
        [JsonProperty("sys")]
        public Info info { get; set; }

        [JsonProperty("wind")]
        public Wind wind { get; set; }
    }
}
