using Microsoft.Extensions.DependencyInjection;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using ServicePetShop.Infra.Repositorio;
using ServicePetShop.Service.Servico;

namespace ServicePetShop.Api.Configuracoes
{
    public static class RegistrarInstanciaConfiguracao
    {
        public static void Registrar(this IServiceCollection services)
        {

            
            #region Serviço
            services.AddTransient<IAgendamentoServico, AgendamentoServico>();
            services.AddTransient<IAnimalServico, AnimalServico>();
            services.AddTransient<IServicosServico, ServicosServico>();
            services.AddTransient<IUsuarioServico, UsuarioServico>();
            services.AddTransient<IEmpresaServico, EmpresaServico>();
            #endregion

            #region Serviço Validações
            #endregion

            #region Repositório
            services.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));
            services.AddScoped<IAgendamentoRepositorio, AgendamentoRepositorio>();
            services.AddScoped<IAnimalRepositorio, AnimalRepositorio>();
            services.AddScoped<IServicosRepositorio, ServicosRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            #endregion
        }
    }
}
