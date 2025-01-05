using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Entidade.v1
{
    public class Agendamento : EntidadeBase
    {
        public int Controle { get; set; }
        public int IdAgendamento { get; set; }
        public int IdServico { get; set; }
        public int IdAnimal { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public string Status { get; set; }
        public Animal Animal { get; set; }
        public Servicos Servico { get; set; }
        public Usuario Usuario { get; set; }
        //public Empresa Empresa { get; set; }
    }
}
