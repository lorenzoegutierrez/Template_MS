using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
