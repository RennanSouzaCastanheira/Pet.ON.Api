using ServicePetShop.Domain.Dtos.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePetShop.Domain.Interfaces.Servico.v1
{
    public interface IAgendamentoServico
    {
        List<BuscarAgendamentoResDto> Buscar(BuscarAgendamentoReqDto dto);
        Task<AdicionarAgendamentoResDto> Adicionar(AdicionarAgendamentoReqDto dto);
    }
}
