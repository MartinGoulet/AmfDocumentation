﻿using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serveur.API;
using Serveur.API.Infrastructure;
using Serveur.API.Infrastructure.Repositories.GroupeServeurRepository;
using Serveur.API.Infrastructure.Repositories.ServeurRepository;
using Swashbuckle.AspNetCore.Swagger;

public static class AddCustomExtensionMethods
{
    public static IServiceCollection AddCustomMVC(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        return services;
    }

    public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Info
            {
                Title = "Swagger Xml Serveur API",
                Version = "v1"
            });

            // //Locate the XML file being generated by ASP.NET...
            // var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
            // var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            // //... and tell Swagger to use those XML comments.
            // c.IncludeXmlComments(xmlPath);
        });

        return services;
    }

    public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddDbContext<ServeurContext>(options =>
        // {
        //     // options.UseSqlServer(configuration["ConnectionString"],
        //     //                      sqlServerOptionsAction: sqlOptions =>
        //     //                      {
        //     //                          sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
        //     //                          //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
        //     //                          sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
        //     //                      });

        //     // // Changing default behavior when client evaluation occurs to throw. 
        //     // // Default in EF Core would be to log a warning when client evaluation is performed.
        //     // options.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
        //     // //Check Client vs. Server evaluation: https://docs.microsoft.com/en-us/ef/core/querying/client-eval

        //     options.UseInMemoryDatabase("ServeurDb", null);
        // });
        
        services.AddDbContext<ServeurContext>(opt => {
             opt.UseInMemoryDatabase("ServeurDb", null)
                .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning));
        });
        
        return services;
    }


    public static IServiceCollection AddCustomIntegration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IServeurRepository, ServeurRepository>();
        services.AddTransient<IGroupeServeurRepository, GroupeServeurRepository>();

        return services;
    }

    public static IServiceCollection AddCustomCors(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));

        return services;
    }

    public static async Task<IApplicationBuilder> SeedData(this IApplicationBuilder app) 
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ServeurContext>();

            await ServeurContextSeed.SeedAsync(context);
        }
        
        return app;
    }
}