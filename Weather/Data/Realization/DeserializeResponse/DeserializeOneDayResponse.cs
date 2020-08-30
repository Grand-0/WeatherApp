using Newtonsoft.Json;
using System.Text.Json;
using Weather.Data;
using WeatherAppWPF.Data.GhostEntity.Intefaces;

namespace WeatherAppWPF.Data.Realization.DeserializeResponse
{
    public class DeserializeOneDayResponse : IDeserializeResponse
    {
        public WeatherModel GetWeatherInfo(string jsonString)
        {
            WeatherModel deserializationModel = JsonConvert.DeserializeObject<WeatherModel>(jsonString);
            return deserializationModel;
        }
    }
}
