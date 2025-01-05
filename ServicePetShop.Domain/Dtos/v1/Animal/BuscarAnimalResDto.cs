using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1
{
    public class BuscarAnimalResDto
    {
        public int IdAnimal { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string TipoAnimal { get; set; }
    }
}
