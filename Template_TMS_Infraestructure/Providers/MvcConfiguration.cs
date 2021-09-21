using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Template_TMS_Infraestructure.Providers
{
    public static class MvcConfiguration
    {
        public static IServiceCollection ConfigureMvcServices(this IServiceCollection services)
        {
            /*services.AddCors();
            services.AddSuperPresenter();
            */
            return services;
        }

        public static IApplicationBuilder ConfigureMvc(this IApplicationBuilder app)
        {
            /*app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });*/

            return app;
        }
    }
}
