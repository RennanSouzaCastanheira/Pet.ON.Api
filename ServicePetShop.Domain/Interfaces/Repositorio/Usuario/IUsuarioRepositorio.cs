using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePetShop.Domain.Interfaces.Repositorio
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Task<IQueryable<Usuario>> GetByParameters(BuscarUsuarioReqDto dto);
    }
}
