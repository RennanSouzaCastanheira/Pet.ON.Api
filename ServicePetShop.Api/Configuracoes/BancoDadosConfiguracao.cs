using Microsoft.Extensions.Configuration;
using System;

namespace ServicePetShop.Api.Configuracoes
{
    public class BancoDadosConfiguracao
    {
        public string ConnectionString { get; set; }
        
        public BancoDadosConfiguracao(IConfiguration configuration)
        {
            ConnectionString = configuration["ConexaoMySql:MySqlConnectionString"];
            
        }
    }
}
