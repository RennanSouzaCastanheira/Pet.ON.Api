using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServicePetShop.Api.Configuracoes
{
    public static class VersionamentoConfiguracao
    {
        public static void AddVersionamentoConfiguracao(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddMvc(option => option.EnableEndpointRouting = false);

            //services.AddApiVersioning(config =>
            //{
            //    config.ReportApiVersions = true;

            //});

            //services.AddVersionedApiExplorer(p =>
            //{
            //    p.GroupNameFormat = "'v'VVV";
            //    p.SubstituteApiVersionInUrl = true;
            //});

        }

        //public static void UseVersionamentoConfiguration(this IApplicationBuilder app)
        //{
        //    if (app == null) throw new ArgumentNullException(nameof(app));

        //    app.UseMvc()
        //       .UseApiVersioning()
        //       .UseMvcWithDefaultRoute();
        //}
    }
}
