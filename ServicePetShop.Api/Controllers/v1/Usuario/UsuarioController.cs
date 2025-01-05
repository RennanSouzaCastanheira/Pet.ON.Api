using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicePetShop.Api.Controllers;
using ServicePetShop.Domain.Dtos.v1;
using ServicePetShop.Domain.Dtos.v1.Usuario;
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
    public class UsuarioController : BaseController
    {

        private IUsuarioServico _usuarioServico;
        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        #region GET
        /// <summary>
        /// Retornar uma lista de usuarios com base nos filtros.
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<BuscarUsuarioResDto>), 200)]
        public IActionResult Buscar([FromQuery] BuscarUsuarioReqDto dto)
        {
            return ExecuteOperation(() => _usuarioServico.Buscar(dto));
        }
        #endregion

        #region Post
        /// <summary>
        /// Adicionar usuario.
        /// </summary>
        /// <returns>Retorna usuario</returns>
        [HttpPost]
        //[Authorize]
        [ProducesResponseType(typeof(AdicionarUsuarioResDto), 200)]
        public async Task<IActionResult> Adicionar([FromBody] AdicionarUsuarioReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _usuarioServico.Cadastrar(dto);
                return Ok();

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        #endregion

        #region Post
        /// <summary>
        /// Adicionar usuario e criando o cadastro do pet shop.
        /// </summary>
        /// <returns>Retorna usuario</returns>
        [HttpPost("AdicionarUsuarioPetShop")]
        //[Authorize]
        [ProducesResponseType(typeof(AdicionarUsuarioResDto), 200)]
        public async Task<IActionResult> AdicionarUsuarioPetShop([FromBody] AdicionarUsuarioReqDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var servico = _usuarioServico.CadastrarUsuarioPetShop(dto);
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
[ApiController]
[Route("api/[controller]")]
public class UsuarioController : BaseController
{
    private readonly IUsuarioServico _usuarioServico;

    public UsuarioController(IUsuarioServico usuarioServico)
    {
        _usuarioServico = usuarioServico;
    }

  
}
