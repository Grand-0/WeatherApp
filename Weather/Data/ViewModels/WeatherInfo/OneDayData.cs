using System;
using System.Collections.Generic;
using System.Text;
using Weather.Data;
using WeatherAppWPF.Data.Parse;
using WeatherAppWPF.Data.Realization.DeserializeResponse;
using WeatherAppWPF.Data.RequestPath;

namespace WeatherAppWPF.Data.ViewModels
{
    public class OneDayData
    {
        private OneDay Today;
        private ParseOneDay parse;
        private DeserializeOneDayResponse response;

        public OneDayData(string firstTocken, string cityName, string SecondTocken)
        {
            Today = new OneDay(firstTocken, cityName, SecondTocken);
            parse = new ParseOneDay();
            response = new DeserializeOneDayResponse();
        }

        public WeatherModel GetWeather()
        {
            WeatherModel weather = new WeatherModel();
            return response.GetWeatherInfo(parse.GetResponce(Today), weather);
        }
    }
}
