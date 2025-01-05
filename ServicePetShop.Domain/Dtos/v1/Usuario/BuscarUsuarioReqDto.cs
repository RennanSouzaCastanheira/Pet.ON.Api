using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1
{
    public class BuscarUsuarioReqDto
    {
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Id { get; set; }
        public int? IdAnimal { get; set; }
    }
}
