using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Securite.Domain;
using Securite.Domain.Repositories;
using Securite.Infrastructure;
using Securite.Infrastructure.Repositories;

namespace Securite.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AjouterRepository(this IServiceCollection services)
        {
            services.AddScoped<IEnvironnementRepository, EnvironnementRepository>();
            services.AddScoped<ISystemeRepository, SystemeRepository>();

            return services;
        }

        public static IServiceCollection AjouterEntityFramework(this IServiceCollection services)
        {
            services.AddDbContext<SecuriteContext>(opt =>
            {
                opt.UseInMemoryDatabase("SecuriteDb", null)
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