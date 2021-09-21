
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Template_TMS_Infraestructure.DatabaseInMemory;
using Template_TMS_Infraestructure.DataContext;

namespace Template_TMS_Infraestructure.Providers
{
    public static class PersistanceConfiguration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase(databaseName: "WeatherForecast"));            
            
            return services;
        }
    }
}
