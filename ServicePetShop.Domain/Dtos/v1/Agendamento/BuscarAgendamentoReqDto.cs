using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1
{
    public class BuscarAgendamentoReqDto
    {
        public int Controle { get; set; }
        public int IdAgendamento { get; set; }
        public int IdServico { get; set; }
        public int IdAnimal { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public string Status { get; set; }
    }
}
