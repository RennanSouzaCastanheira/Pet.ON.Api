using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Infra.Repositorio
{
    public class AnimalRepositorio : BaseRepositorio<Animal>, IAnimalRepositorio
    {
        private DbSet<Animal> _dataset;
        public AnimalRepositorio(ServicePetShopContexto context) : base(context)
        {
            _dataset = _context.Set<Animal>();
        }

    }
}
