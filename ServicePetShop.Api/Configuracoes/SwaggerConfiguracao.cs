using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ServicePetShop.Api.Configuracoes
{
    public static class SwaggerConfiguracao
    {
        public static void AddSwaggerConfiguracao(this IServiceCollection services, IConfiguration Configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

        //    services.AddSwaggerGen(options =>
        //    {
        //        var provider = services.BuildServiceProvider()
        //                               .GetRequiredService<IApiVersionDescriptionProvider>();

        //        foreach (var description in provider.ApiVersionDescriptions)
        //        {
        //            options.SwaggerDoc(description.GroupName, new OpenApiInfo
        //            {
        //                Title = Configuration.GetSection("ApiDocTitle").Value + " " + description.GroupName,
        //                Description = "Documentação dos métodos da API - Service Pet Shop",
        //            });

        //            options.AddSecurityDefinition("Bearer",
        //            new OpenApiSecurityScheme
        //            {
        //                In = ParameterLocation.Header,
        //                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
        //                Name = "Authorization",
        //                Type = SecuritySchemeType.ApiKey,
        //                Scheme = "Bearer"
        //            });

        //            options.AddSecurityRequirement(new OpenApiSecurityRequirement()
        //            {
        //                {
        //                    new OpenApiSecurityScheme
        //                    {
        //                        Reference = new OpenApiReference
        //                        {
        //                            Type = ReferenceType.SecurityScheme,
        //                            Id = "Bearer"
        //                        },
        //                        Scheme = "Bearer",
        //                        Name = "Bearer",
        //                        In = ParameterLocation.Header,

        //                    },
        //                    new List<string>()
        //                }
        //            });
        //        }
        //        options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
        //        options.EnableAnnotations();

        //        //Coleta arquivos XML gerados por qualquer um dos projetos
        //        var currentAssembly = Assembly.GetExecutingAssembly();

        //        var xmlDocs = currentAssembly.GetReferencedAssemblies()
        //        .Union(new AssemblyName[] { currentAssembly.GetName() })
        //        .Select(a => Path.Combine(Path.GetDirectoryName(currentAssembly.Location), $"{a.Name}.xml"))
        //        .Where(f => File.Exists(f)).ToArray();

        //        Array.ForEach(xmlDocs, (d) =>
        //        {
        //            options.IncludeXmlComments(d);
        //        });
        //    });
        }

        //public static void UseSwaggerConfiguration(this IApplicationBuilder app//, IApiVersionDescriptionProvider provider)
        //{
        //    if (app == null) throw new ArgumentNullException(nameof(app));

        //    app.UseSwagger();

        //    app.UseSwaggerUI(options =>
        //    {
        //        string swaggerJsonBasePath = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";

        //        foreach (var description in provider.ApiVersionDescriptions)
        //        {
        //            options.SwaggerEndpoint(
        //            $"{swaggerJsonBasePath}/swagger/{description.GroupName}/swagger.json",
        //            description.GroupName.ToUpperInvariant());
        //        }
        //    });
        //}
    }
}
