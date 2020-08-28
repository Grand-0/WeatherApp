using Weather.Data;

namespace WeatherAppWPF.Data.ViewModels
{
    public class OneDayViewModel
    {
        public OneDayViewModel(string city)
        {
            OneDayData data = new OneDayData("api.openweathermap.org/data/2.5/weather?q=", city, "&appid=");
            model = data.GetWeather();
        }

        private WeatherModel model;

        public string GetCityName()
        {
            return model.city.Name;
        }

        public string GetLongitude()
        {
            return model.coordinate.Longitude;
        }

        public string GetLatitude()
        {
            return model.coordinate.Latitude;
        }

        public string GetWeatherDescription()
        {
            return model.desc.WeatherDescription;
        }

        public string GetWeatherState()
        {
            return model.desc.State;
        }

        public decimal GetTempInCelsius()
        {
            return (model.parameters.TempInKelvin - 273.15M);
        }

        public decimal GetTempFeelLike_InCelsius()
        {
            return (model.parameters.FeelsLikeInKelvin - 273.15M);
        }

        public decimal GetPressure()
        {
            return model.parameters.Pressure;
        }

        public decimal GetHumidity()
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

        public decimal GetWindSpeed()
        {
            return model.wind.Speed;
        }
    }
}
