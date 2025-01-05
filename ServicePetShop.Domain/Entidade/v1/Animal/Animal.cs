using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Entidade.v1
{
    public class Animal : EntidadeBase
    {
        public int IdAnimal { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string TipoAnimal { get; set; }
        public string Sexo { get; set; }
    }
}