using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Repositorio
{
    public class ServicosRepositorio : BaseRepositorio<Servicos>, IServicosRepositorio
    {
        private DbSet<Servicos> _dataset;
        public ServicosRepositorio(ServicePetShopContexto context) : base(context)
        {
            _dataset = _context.Set<Servicos>();
        }

    }
}
