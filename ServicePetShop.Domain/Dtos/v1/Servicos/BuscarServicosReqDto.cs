using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePetShop.Domain.Dtos.v1
{
    public class BuscarServicosReqDto
    {        
        public int IdServico { get; set; }
        public int IdEmpresa { get; set; }        
    }
}
