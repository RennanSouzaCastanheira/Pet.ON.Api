using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Interfaces.Servico.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ServicePetShop.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private IServicosServico _servicosServico;
        public ServicosController(IServicosServico servicosServico)
        {
            _servicosServico = servicosServico;
        }

        #region GET
        /// <summary>
        /// Retornar uma lista de servicos de pet shop com base nos filtros.
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [HttpGet]
        //[Authorize]
        [ProducesResponseType(typeof(List<BuscarServicosResDto>), 200)]
        public async Task<IActionResult> Buscar([FromQuery] BuscarServicosReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _servicosServico.Buscar(dto);
                return Ok(await servico);

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion

    }
}
