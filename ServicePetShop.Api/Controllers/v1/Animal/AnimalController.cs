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
    public class AnimalController : ControllerBase
    {
        private IAnimalServico _animalServico;
        public AnimalController(IAnimalServico animalServico)
        {
            _animalServico = animalServico;
        }

        #region GET
        /// <summary>
        /// Retornar uma lista de animais com base nos filtros.
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [HttpGet]
        //[Authorize]
        [ProducesResponseType(typeof(List<BuscarAnimalResDto>), 200)]
        public async Task<IActionResult> Buscar([FromQuery] BuscarAnimalReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _animalServico.Buscar(dto);
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
