using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Entidade.v1
{
    public class Empresa : EntidadeBase
    {
        public int IdEmpresa { get; set; }
        public string DescricaoNomeFisica { get; set; }
        public string CPFCNPJ { get; set; }
        public string Apelido { get; set; }
        public string FisicaJuridica { get; set; }
        public string Telefone { get; set; }
    }
}
