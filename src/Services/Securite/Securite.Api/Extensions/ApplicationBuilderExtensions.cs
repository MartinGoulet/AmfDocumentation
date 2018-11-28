using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Securite.Infrastructure;

namespace Securite.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task<IApplicationBuilder> SeedData(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SecuriteContext>();

                await SecuriteContextSeed.SeedAsync(context);
            }

            return app;
        }

        public static IApplicationBuilder UtiliserSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger()
               .UseSwaggerUI(c =>
              {
                  c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger XML Serveur API v1");
              });

            return app;
        }



    }
}