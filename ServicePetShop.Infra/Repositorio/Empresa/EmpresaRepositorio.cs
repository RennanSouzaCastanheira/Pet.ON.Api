using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Repositorio
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
    {
        private DbSet<Empresa> _dataset;
        public EmpresaRepositorio(ServicePetShopContexto context) : base(context)
        {
            _dataset = _context.Set<Empresa>();
        }

    }
}
