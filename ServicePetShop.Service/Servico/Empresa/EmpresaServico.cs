using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;

namespace ServicePetShop.Service.Servico
{
    public class EmpresaServico : IEmpresaServico
    {
        private readonly IBaseRepositorio<Empresa> _baseRepositorio;
        private readonly IMapper _mapper;

        public EmpresaServico(IBaseRepositorio<Empresa> baseRepositorio, IMapper mapper)
        {
            _baseRepositorio = baseRepositorio;
            _mapper = mapper;
        }

        public async Task<AtualizarEmpresaResDto> Atualizar(AtualizarEmpresaReqDto dto)
        {
            try
            {
                var empresa = _mapper.Map<Empresa>(dto);
                empresa.IdEmpresa = empresa.IdEmpresa;
                var resultado = await _baseRepositorio.UpdateAsync(empresa);
                return _mapper.Map<AtualizarEmpresaResDto>(resultado);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<BuscarEmpresaResDto>> Buscar(BuscarEmpresaReqDto dto)
        {
            var query = _baseRepositorio.GetAll();

            if (dto.IdEmpresa > 0)
                query = query.Where(x => x.IdEmpresa == dto.IdEmpresa);

            //mapeando atravez por linq
            var resultado = (from result in query
                             select new BuscarEmpresaResDto
                             {
                                 IdEmpresa = result.IdEmpresa,
                                 DescricaoNomeFisica = result.DescricaoNomeFisica,
                                 CPFCNPJ = result.CPFCNPJ,
                                 Apelido = result.Apelido,
                                 FisicaJuridica = result.FisicaJuridica,
                                 Telefone = result.Telefone

                             }).AsEnumerable();

            return resultado;

        }

        public async Task<AdicionarEmpresaResDto> Cadastrar(AdicionarEmpresaReqDto dto)
        {
            try
            {
                var empresa = _mapper.Map<Empresa>(dto);
                var resultado = await _baseRepositorio.InsertAsync(empresa);
                return _mapper.Map<AdicionarEmpresaResDto>(resultado);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
