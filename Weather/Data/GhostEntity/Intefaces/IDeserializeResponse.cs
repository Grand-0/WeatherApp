using System;
using System.Collections.Generic;
using System.Text;
using Weather.Data;

namespace WeatherAppWPF.Data.GhostEntity.Intefaces
{
    public interface IDeserializeResponse
    {
        WeatherModel GetWeatherInfo(string jsonString, WeatherModel deserializationModel);
    }
}
