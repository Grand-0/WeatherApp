using WeatherAppWPF.Data.GhostEntity.Intefaces;
using WeatherAppWPF.Data.RequestPath;

namespace WeatherAppWPF.Data.Realization.OverridersInfo
{
    public class OverriderInfoOneDay : IOverrideInfo<OneDay>
    {
        public OneDay Path { get; set; }
    }
}
