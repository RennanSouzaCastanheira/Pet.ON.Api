using AutoMapper;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Dtos.v1.Usuario;
using ServicePetShop.Domain.Entidade.v1;

namespace ServicePetShop.Api.Configuracoes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agendamento, BuscarAgendamentoResDto>().ReverseMap();

            #region Usuario
            CreateMap<Usuario, BuscarUsuarioResDto>().ReverseMap();
            CreateMap<Usuario, AdicionarUsuarioReqDto>().ReverseMap();
            CreateMap<Usuario, AdicionarUsuarioResDto>().ReverseMap();
            #endregion

            #region Empresa
            CreateMap<Empresa, AdicionarEmpresaReqDto>().ReverseMap();
            CreateMap<Empresa, AdicionarEmpresaResDto>().ReverseMap();
            CreateMap<Empresa, AtualizarEmpresaReqDto>().ReverseMap();
            CreateMap<Empresa, AtualizarEmpresaResDto>().ReverseMap();

            #endregion
        }
    }
}
