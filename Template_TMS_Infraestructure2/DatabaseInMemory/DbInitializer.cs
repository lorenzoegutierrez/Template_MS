
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Template_TMS_Infraestructure.DataContext;

namespace Template_TMS_Infraestructure.DatabaseInMemory
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if(_context.WeatherForecast.Any())
                {
                    return;
                }

                _context.WeatherForecast.AddRange(
                    new WeatherForecastDb { Date = new DateTime(), TemperatureC = 22, Descripcion = "Example 1"},
                    new WeatherForecastDb { Date = new DateTime(), TemperatureC = 2, Descripcion = "Example 2" },
                    new WeatherForecastDb { Date = new DateTime(), TemperatureC = 12, Descripcion = "Example 3" }
                    );

                _context.SaveChanges();
            }
        }
    }
}
