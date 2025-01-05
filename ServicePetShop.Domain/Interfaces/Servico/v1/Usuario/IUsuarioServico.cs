using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Dtos.v1.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePetShop.Domain.Interfaces.Servico.v1
{
    public interface IUsuarioServico
    {
        Task<IQueryable<BuscarUsuarioResDto>> Buscar(BuscarUsuarioReqDto dto);
        Task Cadastrar(AdicionarUsuarioReqDto dto);

        Task<AdicionarUsuarioResDto> CadastrarUsuarioPetShop(AdicionarUsuarioReqDto dto);

    }
}
