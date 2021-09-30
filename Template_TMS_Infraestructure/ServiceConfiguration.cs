using System.Reflection;

using FluentValidation.AspNetCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Template_TMS_Infraestructure.Providers;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ServiceConfiguration));

        services.AddControllers().AddFluentValidation(fv =>
        {
            fv.RegisterValidatorsFromAssembly(Assembly.Load("Template_TMS_Application"));
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "Template_TMS", Version = "v1" });
        });

        services.ConfigureMediatrServices();

        services.ConfigureMvcServices();
        
        services.ConfigurePersistenceServices();        

        return services;
    }

    public static IApplicationBuilder Configure(
        this IApplicationBuilder app,
        WebApplication hostEnvironment)
    {        
        app.ConfigureMvc(hostEnvironment);

        return app;
    }
}