using WeatherAppWPF.Data.GhostEntity.BaseClasses;

namespace WeatherAppWPF.Data.GhostEntity.Intefaces
{
    public interface IOverrideInfo<T> where T : BaseOpenWeatherMap
    {
        T Path { get; set; }
    }
}
