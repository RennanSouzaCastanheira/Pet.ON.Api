using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePetShop.Service.Servico
{
    public class AnimalServico : IAnimalServico
    {
        private readonly IBaseRepositorio<Animal> _baseRepositorio;

        public AnimalServico(IBaseRepositorio<Animal> baseRepositorio)
        {
            _baseRepositorio = baseRepositorio;
        }

        public async Task<IEnumerable<BuscarAnimalResDto>> Buscar(BuscarAnimalReqDto dto)
        {
            var query = _baseRepositorio.GetAll();

            if (dto.IdAnimal > 0)
                query = query.Where(x => x.IdAnimal == dto.IdAnimal);

            if (!string.IsNullOrEmpty(dto.Nome))
                query = query.Where(x => x.Nome.Equals(dto.Nome));

            if (!string.IsNullOrEmpty(dto.Raca))
                query = query.Where(x => x.Raca.Equals(dto.Raca));

            if (!string.IsNullOrEmpty(dto.TipoAnimal))
                query = query.Where(x => x.TipoAnimal.Equals(dto.TipoAnimal));

            //mapeando atravez por linq
            var resultado = (from result in query
                             select new BuscarAnimalResDto
                             {
                                 IdAnimal = result.IdAnimal,
                                 Nome = result.Nome,
                                 Raca = result.Raca,
                                 TipoAnimal = result.TipoAnimal
                             }).AsEnumerable();

            return resultado;

        }
    }
}