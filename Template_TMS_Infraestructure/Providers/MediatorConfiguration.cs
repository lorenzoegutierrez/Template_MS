using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

using MediatR;

namespace Template_TMS_Infraestructure.Providers
{
    public static class MediatorConfiguration
    {
        public static IServiceCollection ConfigureMediatrServices(this IServiceCollection services)
        {            
            services.AddMediatR(Assembly.Load("Template_TMS_Application"));                        

            return services;
        }
    }
}
