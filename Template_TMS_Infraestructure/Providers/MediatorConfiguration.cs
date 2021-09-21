using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace Template_TMS_Infraestructure.Providers
{
    public static class MediatorConfiguration
    {
        public static IServiceCollection ConfigureMediatrServices(this IServiceCollection services)
        {
            AppDomain.CurrentDomain.Load("Template_TMS_Application");
            AppDomain.CurrentDomain.Load("Template_TMS_Api");

            //var superAssemblies = AppDomain.CurrentDomain.GetSuperLoadedAssemblies();

            //services.AddAutoMapper(superAssemblies);

            /*services.AddSuperMediator(superAssemblies);
            services.AddSuperMediatorValidation(superAssemblies);*/

            return services;
        }
    }
}
