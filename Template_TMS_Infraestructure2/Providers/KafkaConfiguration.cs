﻿
using Microsoft.Extensions.DependencyInjection;

namespace Template_TMS_Infraestructure.Providers
{
    public static class KafkaConfiguration
    {
        public static IServiceCollection ConfigureKafkaServices(this IServiceCollection services)
        {
            //services.AddSuperSilverback();
            //services.AddEndpointsConfigurator<EndpointsConfigurator>();

            return services;
        }
    }
}
