using AutoMapper;
using Moq;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Entidade.v1;
using ServicePetShop.Domain.Interfaces.Repositorio;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using ServicePetShop.Service.Servico;
using System.Collections.Generic;
using Xunit;

namespace ServicePetShop.Teste.CasoDeTeste
{
    public class AgendamentoTeste
    {       

        //#region Deve Incluir Com Sucesso

        //[Fact]
        //public async void DeveIncluirComSucesso()
        //{

        //    AdicionarFamiliaExcecaoReqDto dtoReq = new AdicionarFamiliaExcecaoReqDto()
        //    {
        //        IdFamilia = 1580
        //    };

        //    var familiaExcecaoServico = new FamiliaExcecaoServico(
        //                                        _controleNotificacaoMock.Object,
        //                                        _familiaExcecaoRepositorio.Object,
        //                                        _familiaExcecaoValidacaoServico.Object
        //                                        );

        //    await familiaExcecaoServico.Cadastrar(dtoReq);

        //    _familiaExcecaoRepositorio.Verify(f => f.InsertAsync(It.Is<FamiliaExcecao>(arg => arg.IdFamilia == dtoReq.IdFamilia)), Times.Once());
        //}
        //#endregion

        //#region Deve Excluir Com Sucesso

        //[Fact]
        //public async void DeveExcluirComSucesso()
        //{

        //    int idFamilia = 1580;

        //    var familiaExcecaoServico = new FamiliaExcecaoServico(
        //                                        _controleNotificacaoMock.Object,
        //                                        _familiaExcecaoRepositorio.Object,
        //                                        _familiaExcecaoValidacaoServico.Object
        //                                        );

        //    await familiaExcecaoServico.Excluir(idFamilia);

        //    _familiaExcecaoRepositorio.Verify(f => f.DeleteAsync(It.Is<FamiliaExcecao>(arg => arg.IdFamilia == idFamilia)), Times.Once());
        //}
        //#endregion

        //#region Deve Retornar Lista Familia Excecao
        //[Fact]
        //public async void DeveRetornarListaFamiliaExcecao()
        //{
        //    var familiaExcecao = new FamiliaExcecao(1580, DateTime.Now);

        //    _familiaExcecaoRepositorio.Setup(s => s.GetAll()).Returns(() => new[] { familiaExcecao }.AsQueryable());


        //    var familiaExcecaoServico = new FamiliaExcecaoServico(
        //                                        _controleNotificacaoMock.Object,
        //                                        _familiaExcecaoRepositorio.Object,
        //                                        _familiaExcecaoValidacaoServico.Object
        //                                        );

        //    await familiaExcecaoServico.Obter();

        //    _familiaExcecaoRepositorio.Verify(r => r.GetAll(), Times.Once);
        //}
        //#endregion

        [Fact]            
        public void RetornarListaAgendamento()
        {
            // arrange
            Mock<IBaseRepositorio<Agendamento>> baseRepositorio = new Mock<IBaseRepositorio<Agendamento>>();
            Mock<IMapper> mapper = new Mock<IMapper>();
            Mock<IAgendamentoServico> mock = new Mock<IAgendamentoServico>();

            BuscarAgendamentoReqDto dto = new BuscarAgendamentoReqDto();
            List<BuscarAgendamentoResDto> resDto = new List<BuscarAgendamentoResDto>();

            mock.Setup(x => x.Buscar(dto)).Returns(resDto);
            AgendamentoServico verif = new AgendamentoServico(baseRepositorio.Object, mapper.Object);

            // act
            var resultadoEsperado = mock.Object.Buscar(dto);
            var resultado = verif.Buscar(dto);

            // assert
            //Assert.AreNotEqual(resultado, resultadoEsperado);

        }
    }
}