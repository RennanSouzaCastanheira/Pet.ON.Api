using Microsoft.AspNetCore.Cors;
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
    public class AgendamentoController : ControllerBase
    {
        private IAgendamentoServico _agendamentoServico;
        public AgendamentoController(IAgendamentoServico agendamentoServico)
        {
            _agendamentoServico = agendamentoServico;
        }

        #region GET
        /// <summary>
        /// Retornar uma lista de agendamentos com base nos filtros.
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<BuscarAgendamentoResDto>), 200)]
        public IActionResult Buscar([FromQuery] BuscarAgendamentoReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {                
                return Ok(_agendamentoServico.Buscar(dto));

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion


    }
}
