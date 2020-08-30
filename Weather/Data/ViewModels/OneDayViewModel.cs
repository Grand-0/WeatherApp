using System.Linq;
using Weather.Data;
using WeatherAppWPF.Data.Entity.WeatherEntities;

namespace WeatherAppWPF.Data.ViewModels
{
    public class OneDayViewModel
    {
        public OneDayViewModel(string city)
        {
            OneDayData data = new OneDayData(city);
            model = data.GetWeather();
            desc = model.descriptions.First();
        }

        private WeatherModel model;
        private Desc desc;

        public string GetCityName()
        {
            return model.cityName;
        }

        public float GetLongitude()
        {
            return model.coordinate.Longitude;
        }

        public float GetLatitude()
        {
            return model.coordinate.Latitude;
        }

        public float GetTempInCelsius()
        {
            return (model.parameters.TempInKelvin - 273.15f);
        }

        public float GetTempFeelLike_InCelsius()
        {
            return (model.parameters.FeelsLikeInKelvin - 273.15f);
        }

        public float GetPressure()
        {
            return model.parameters.Pressure;
        }

        public float GetHumidity()
        {
            return model.parameters.Humidity;
        }

        public int GetCountryId()
        {
            return model.info.CountryId;
        }

        public string GetCountryName()
        {
            return model.info.CountryName;
        }

        public string GetDescription()
        {
            return desc.Description; 
        }

        public string GetLongDescription()
        {
            return desc.LongDescription;
        }

        public float GetWindSpeed()
        {
            return model.wind.Speed;
        }
    }
}
