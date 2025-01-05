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
    public class ServicosServico : IServicosServico
    {
        private readonly IBaseRepositorio<Servicos> _baseRepositorio;

        public ServicosServico(IBaseRepositorio<Servicos> baseRepositorio)
        {
            _baseRepositorio = baseRepositorio;
        }

        public async Task<IEnumerable<BuscarServicosResDto>> Buscar(BuscarServicosReqDto dto)
        {
            var query = _baseRepositorio.GetAll();

            if (dto.IdServico > 0)
                query = query.Where(x => x.IdServico == dto.IdServico);

            if (dto.IdEmpresa > 0)
                query = query.Where(x => x.IdEmpresa == dto.IdEmpresa);

            //mapeando atravez por linq
            var resultado = (from result in query
                             select new BuscarServicosResDto
                             {
                                 IdServico = result.IdServico,
                                 IdEmpresa = result.IdEmpresa,
                                 Descricao = result.Descricao,
                                 Valor = result.Valor,
                                 QtdeHora = result.QtdeHora,
                                 Observacao = result.Observacao,
                                 Oferta = result.Oferta,
                                 ValorOferta = result.ValorOferta
                             }).AsEnumerable();

            return resultado;
        }
    }
}