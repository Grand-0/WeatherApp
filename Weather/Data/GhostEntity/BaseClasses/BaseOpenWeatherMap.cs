using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAppWPF.Data.GhostEntity.BaseClasses
{
    public abstract class BaseOpenWeatherMap
    {
        public string FirstToken { get; set; }
        public string CityName { get; set; }
        public string SecondToken { get; set; }
        public string RequestKey { get; set; } = "7e743011271da5a7d217f862c561c6fb";
    }
}
