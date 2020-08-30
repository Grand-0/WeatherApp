using System;
using System.Collections.Generic;
using System.Text;
using WeatherAppWPF.Data.GhostEntity.BaseClasses;

namespace WeatherAppWPF.Data.RequestPath
{
    public class OneDay : BaseOpenWeatherMap
    {
        public OneDay(string name)
        {
            FirstToken = "https://api.openweathermap.org/data/2.5/weather?q=";
            CityName = name;
            SecondToken = "&appid=";
        }
    }
}
