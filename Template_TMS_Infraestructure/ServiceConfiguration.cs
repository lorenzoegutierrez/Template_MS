using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Template_TMS_Infraestructure.Providers;

public static class ServiceConfiguration2
{
    public static IServiceCollection ConfigureServices2(this IServiceCollection services)
    {
        services.ConfigureMvcServices();

        services.ConfigureKafkaServices();
        services.ConfigureMediatrServices();
        services.ConfigurePersistenceServices();

        //services.Configure<ConsentsConfig>(configuration.GetSection("ConsentsConfig"));

        return services;
    }

    public static IApplicationBuilder Configure(
        this IApplicationBuilder app,
        IConfiguration configuration
        )
    {
        app.UsePathBase(configuration["BasePath"]);
        app.ConfigureMvc();

        return app;
    }
}