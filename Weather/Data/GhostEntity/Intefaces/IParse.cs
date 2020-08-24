using WeatherAppWPF.Data.GhostEntity.BaseClasses;

namespace WeatherAppWPF.Data.GhostEntity.Intefaces
{
    public interface IParse<T> where T : BaseOpenWeatherMap
    {
        string GetResponce(T Path);
    }
}
