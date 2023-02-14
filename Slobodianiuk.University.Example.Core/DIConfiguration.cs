using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Slobodianiuk.University.Example.Core.Interfaces;
using Slobodianiuk.University.Example.Core.Services;
using Slobodianiuk.University.Example.Models.Configuration;

namespace Slobodianiuk.University.Example.Core
{
    public static class DIConfiguration
    {
        public static void RegisterCoreDependencies(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }

        public static void RegisterCoreConfiguration(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.Configure<AppConfig>(configuration.GetSection("AppConfig"));
        }
    }
}
