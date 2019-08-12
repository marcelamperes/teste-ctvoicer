using System.Collections.Generic;
using CTVoicer.Vue.Models;

namespace CTVoicer.Vue.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
