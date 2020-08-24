using WeatherAppWPF.Data.GhostEntity.Intefaces;
using WeatherAppWPF.Data.RequestPath;

namespace WeatherAppWPF.Data.Realization.Overriders
{
    public class OverriderOneDay : IOverrider<OneDay>
    {
        public OneDay OverridePath(OneDay path)
        {
            path.FirstToken = "http://api.openweathermap.org/data/2.5/weather?q=";
            path.SecondToken = "&appid=";
            path.CityName = "Minsk";
            return path;
        }
    }
}
