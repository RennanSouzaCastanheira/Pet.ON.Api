using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1.Usuario
{
    public class AdicionarUsuarioReqDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public DateTime DataPrimeiroAcesso { get; set; }
    }
}
