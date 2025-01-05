using AutoMapper;
using AutoMapper.QueryableExtensions;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Dtos.v1.Usuario;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Utilitarios.Validacoes;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePetShop.Service.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;
        private readonly IEmpresaServico _empresaServico;

        public UsuarioServico(IMapper mapper, IEmpresaServico empresaServico, IUsuarioRepositorio usuarioRepositorio)
        {
            _mapper = mapper;
            _empresaServico = empresaServico;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task Cadastrar(AdicionarUsuarioReqDto dto)
        {
            try
            {
                var usuario = _mapper.Map<Usuario>(dto);

                // Instanciar o validador de objeto
                var validador = new Validador<Usuario>();
                if (!validador.EstaValido(usuario))
                {
                    // Retornar notificações se o objeto não estiver válido
                    var notificacoes = validador.ObterNotificacoes();
                    // Aqui você pode manipular as notificações, por exemplo, enviá-las ao cliente
                    return;
                }

                // Aplicar regras de negócio específicas
                usuario = AplicandoRegrasDeNegocioParaCadastroDeUsuario(usuario);

                // Inserir usuário no repositório
                var resultado = await _usuarioRepositorio.InsertAsync(usuario);
            }
            catch (Exception ex)
            {
                //criar log sobre o qual motivo do erro
                //mandar as notificação pro usuario.


                //_logger.LogError(ex, $@"Erro ao adicionar configuração de importação. Erro: {ex.Message} 
                //                 Parâmetro: {adicionarConfiguracaoImportacaoErp.ToJson()}");
                //_controleNotificacao.AdicionarNotificacao(LocalizacaoCaminho.ErroCadastrarConfiguracaoGeral);
            }

        }

        private Usuario AplicandoRegrasDeNegocioParaCadastroDeUsuario(Usuario usuario)
        {
            return new Usuario { DataPrimeiroAcesso = DateTime.Now };
        }

        public async Task<IQueryable<BuscarUsuarioResDto>> Buscar(BuscarUsuarioReqDto dto)
        {
            var queryUsuario = await _usuarioRepositorio.GetByParameters(dto);            
            return queryUsuario.ProjectTo<BuscarUsuarioResDto>(_mapper.ConfigurationProvider);            
        }

        public async Task<AdicionarUsuarioResDto> CadastrarUsuarioPetShop(AdicionarUsuarioReqDto dto)
        {
            try
            {
                var adicionar = _mapper.Map<Usuario>(dto);
                var empresaDto = new AdicionarEmpresaReqDto
                {
                    DescricaoNomeFisica = adicionar.Nome,
                    Telefone = adicionar.Telefone
                };

                var empresaAdicionado = _empresaServico.Cadastrar(empresaDto);
                adicionar.IdEmpresa = empresaAdicionado.Result.IdEmpresa;
                var resultado = await _usuarioRepositorio.InsertAsync(adicionar);
                return _mapper.Map<AdicionarUsuarioResDto>(resultado);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}