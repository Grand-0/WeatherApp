using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using Weather.Entity;

namespace Weather.Data
{
    public class Weather
    { 
        public Info info { get; set; }

        [JsonProperty("wind")]
        public Wind wind { get; set; }
    }
}
