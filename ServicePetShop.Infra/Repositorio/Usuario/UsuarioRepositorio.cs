using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePetShop.Infra.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        private DbSet<Usuario> _dataset;
        public UsuarioRepositorio(ServicePetShopContexto context) : base(context)
        {
            _dataset = _context.Set<Usuario>();
        }

        public async Task<IQueryable<Usuario>> GetByParameters(BuscarUsuarioReqDto dto)
        {
            var query = _context.Usuario.AsQueryable();

            if (!string.IsNullOrWhiteSpace(dto.Telefone))
                query = query.Where(x => x.Telefone == dto.Telefone);

            if (!string.IsNullOrWhiteSpace(dto.Email))
                query = query.Where(x => x.Email == dto.Email);

            if (!string.IsNullOrWhiteSpace(dto.Senha))
                query = query.Where(x => x.Senha == dto.Senha);

            if (dto.IdEmpresa > 0)
                query = query.Where(x => x.IdEmpresa == dto.IdEmpresa);

            if (dto.Id > 0)
                query = query.Where(x => x.IdUsuario == dto.Id);

            if (dto.IdAnimal > 0)
                query = query.Where(x => x.IdAnimal == dto.IdAnimal);

            return await Task.FromResult(query);
        }
    }
}
