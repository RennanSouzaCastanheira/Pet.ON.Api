using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1
{
    public class BuscarUsuarioResDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Geolocalizacao { get; set; }
        public DateTime DataPrimeiroAcesso { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdAnimal { get; set; }
    }
}
