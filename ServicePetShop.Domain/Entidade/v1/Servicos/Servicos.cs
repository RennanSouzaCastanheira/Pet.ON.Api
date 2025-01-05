using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Entidade.v1
{
    public class Servicos : EntidadeBase
    {
        public int IdServico { get; set; }
        public int IdEmpresa { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public decimal? QtdeHora { get; set; }
        public string Observacao { get; set; }
        public bool Oferta { get; set; }
        public decimal? ValorOferta { get; set; }
    }
}
