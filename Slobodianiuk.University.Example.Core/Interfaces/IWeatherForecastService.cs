using Slobodianiuk.University.Example.Models.Weather;

namespace Slobodianiuk.University.Example.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetRandomForecast();
    }
}
