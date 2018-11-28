using Inventaire.Domain.Repositories;
using Inventaire.Infrastructure;
using Inventaire.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Inventaire.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AjouterRepository(this IServiceCollection services)
        {
            services.AddScoped<IEnvironnementRepository, EnvironnementRepository>();
            services.AddScoped<IServeurRepository, ServeurRepository>();
            services.AddScoped<ISystemeRepository, SystemeRepository>();

            return services;
        }

        public static IServiceCollection AjouterEntityFramework(this IServiceCollection services)
        {
            services.AddDbContext<InventaireContext>(opt =>
            {
                opt.UseInMemoryDatabase("ServeurDb", null)
                    .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            });

            return services;
        }

        public static IServiceCollection AjouterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Swagger Xml Serveur API",
                    Version = "v1"
                });
            });

            return services;
        }

        public static IServiceCollection AjouterCors(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            return services;
        }
    }
}