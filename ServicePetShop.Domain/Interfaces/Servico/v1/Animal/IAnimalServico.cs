using ServicePetShop.Domain.Dtos.v1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicePetShop.Domain.Interfaces.Servico.v1
{
    public interface IAnimalServico
    {
        Task<IEnumerable<BuscarAnimalResDto>> Buscar(BuscarAnimalReqDto dto);

    }
}
