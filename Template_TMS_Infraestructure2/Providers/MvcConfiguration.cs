using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Template_TMS_Infraestructure.Providers
{
    public static class MvcConfiguration
    {
        public static IServiceCollection ConfigureMvcServices(this IServiceCollection services)
        {
            services.AddCors();           

            return services;
        }

        public static IApplicationBuilder ConfigureMvc(this IApplicationBuilder app, WebApplication env)
        {
            if (env.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template_TMS v1"));
            }

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseCors();
            //app.MapControllers();

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });*/

            return app;
        }
    }
}
