using WeatherAppWPF.Data.GhostEntity.BaseClasses;

namespace WeatherAppWPF.Data.GhostEntity.Intefaces
{
    public interface IOverrider<T> where T : BaseOpenWeatherMap
    {
        T OverridePath(T path);
    }
}
