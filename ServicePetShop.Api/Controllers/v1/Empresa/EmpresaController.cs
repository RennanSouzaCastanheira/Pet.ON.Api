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
    public class EmpresaController : ControllerBase
    {

        private IEmpresaServico _empresaServico;
        public EmpresaController(IEmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        #region GET
        /// <summary>
        /// Retornar uma lista de empresa com base nos filtros.
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [HttpGet]
        //[Authorize]
        [ProducesResponseType(typeof(List<BuscarEmpresaResDto>), 200)]
        public async Task<IActionResult> Buscar([FromQuery] BuscarEmpresaReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _empresaServico.Buscar(dto);
                return Ok(await servico);

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion

        #region Post
        /// <summary>
        /// Adicionar empresa.
        /// </summary>
        /// <returns>Retorna empresa</returns>
        [HttpPost]
        //[Authorize]
        //[ProducesResponseType(typeof(), 200)]
        public async Task<IActionResult> AdicionarPetShop([FromBody] AdicionarEmpresaReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _empresaServico.Cadastrar(dto);
                return Ok(servico.Result);

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion

        #region Put
        /// <summary>
        /// atualizar empresa.
        /// </summary>
        /// <returns>Retorna empresa</returns>
        [HttpPut]
        //[Authorize]
        //[ProducesResponseType(typeof(), 200)]
        public async Task<IActionResult> AtualizarEmpresa([FromBody] AtualizarEmpresaReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _empresaServico.Atualizar(dto);
                return Ok(servico.Result);

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion

    }
}
