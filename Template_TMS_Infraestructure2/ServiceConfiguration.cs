using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Template_TMS_Infraestructure.Providers;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ServiceConfiguration));
        services.AddControllers();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "Template_TMS", Version = "v1" });
        });

        services.ConfigureMediatrServices();

        services.ConfigureMvcServices();

        services.ConfigureKafkaServices();
        
        services.ConfigurePersistenceServices();

        //services.Configure<ConsentsConfig>(configuration.GetSection("ConsentsConfig"));

        return services;
    }

    public static IApplicationBuilder Configure(
        this IApplicationBuilder app,
        WebApplication hostEnvironment/*,
        IConfiguration configuration*/
        )
    {
        //app.UsePathBase(configuration["BasePath"]);
        app.ConfigureMvc(hostEnvironment);

        return app;
    }
}