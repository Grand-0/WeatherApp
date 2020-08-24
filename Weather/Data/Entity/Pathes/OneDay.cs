using System;
using System.Collections.Generic;
using System.Text;
using WeatherAppWPF.Data.GhostEntity.BaseClasses;

namespace WeatherAppWPF.Data.RequestPath
{
    public class OneDay : BaseOpenWeatherMap
    {
        public OneDay(string firstT, string name, string secondT)
        {
            FirstToken = firstT;
            CityName = name;
            SecondToken = secondT;
        }
    }
}
