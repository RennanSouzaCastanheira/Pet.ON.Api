using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePetShop.Service.Servico
{
    public class AgendamentoServico : IAgendamentoServico
    {
        private readonly IBaseRepositorio<Agendamento> _baseRepositorio;
        private readonly IMapper _mapper;

        public AgendamentoServico(IBaseRepositorio<Agendamento> baseRepositorio, IMapper mapper)
        {
            _baseRepositorio = baseRepositorio;
            _mapper = mapper;
        }

        #region Buscar

        public List<BuscarAgendamentoResDto> Buscar(BuscarAgendamentoReqDto dto)
        {
            try
            {
                var query = _baseRepositorio.GetAll();

                if (dto.Controle > 0)
                    query = query.Where(x => x.Controle.Equals(dto.Controle));

                if (dto.IdAgendamento > 0)
                    query = query.Where(x => x.IdAgendamento.Equals(dto.IdAgendamento));

                 if (dto.IdAnimal > 0)
                    query = query.Where(x => x.IdAnimal.Equals(dto.IdAnimal));

                if (dto.IdEmpresa > 0)
                    query = query.Where(x => x.IdEmpresa.Equals(dto.IdEmpresa));

                if (dto.IdServico > 0)
                    query = query.Where(x => x.IdServico.Equals(dto.IdServico));

                if (dto.IdUsuario > 0)
                    query = query.Where(x => x.IdUsuario.Equals(dto.IdUsuario));

                //mapeamentos automapper
                var retorno = _mapper.Map<List<BuscarAgendamentoResDto>>(query);

                return retorno;

            }
            catch (Exception ex)
            {

                throw;
            }       
        
        }
        #endregion

        #region Adicionar
        public async Task<AdicionarAgendamentoResDto> Adicionar(AdicionarAgendamentoReqDto dto)
        {
            //if (!ValidateDto<AdicionarAgendamentoResDto>(dto))
            //    return null;

            //var configuracaoImportacaoErp
            //    = adicionarConfiguracaoImportacaoErp.MapTo<ConfiguracaoImportacao>().ValidarCadastrar();

            //if (!EstaValido(configuracaoImportacaoErp)) return;

            //if (await _configuracaoImportacaoValidacao.ExisteConfiguracaoGeral())
            //{
            //    _controleNotificacao.AdicionarNotificacao(LocalizacaoCaminho.ExisteCadastroConfiguracaoGeral);
            //    return;
            //}

            //configuracaoImportacaoErp.AlterarSenhaOrigem(SenhaComum.Criptografar(configuracaoImportacaoErp.SenhaOrigem));
            //configuracaoImportacaoErp.AlterarSenhaDestino(SenhaComum.Criptografar(configuracaoImportacaoErp.SenhaDestino));

            //await _configuracaoImportacaoRepositorio.InsertAsync(configuracaoImportacaoErp);



            //var agendamento = dto.MapTo<Agendamento>();

            //using (var uow = _unitOfWorkManager.Begin())
            //{
            //    agendamento = await _agendamentoRepositorio.InsertAsync(agendamento);

            //    await uow.CompleteAsync().ForAwait();
            //}

            //if (Notification.HasNotification())
            //    return null;

            return null;// agendamento.MapTo<AdicionarAgendamentoResDto>();

        }

        #endregion

    }
}
