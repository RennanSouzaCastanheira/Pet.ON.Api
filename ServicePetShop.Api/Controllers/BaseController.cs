﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System;

namespace ServicePetShop.Api.Controllers
{        
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult ExecuteOperation(Func<Task> operation)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                operation().Wait();
                return NoContent(); // 204 - No Content
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message); // 400 - Bad Request
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Recurso não encontrado."); // 404 - Not Found
            }
            catch (Exception ex)
            {
                // Logar o erro (exemplo: _logger.LogError(ex, "Erro inesperado"))
                return StatusCode((int)HttpStatusCode.InternalServerError, "Erro interno do servidor.");
            }
        }

        protected IActionResult ExecuteOperation<T>(Func<Task<T>> operation)
        {
            try
            {
                var result = operation().Result;

                if (result == null)
                    return NotFound("Recurso não encontrado."); // 404 - Not Found

                return Ok(result); // 200 - OK
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message); // 400 - Bad Request
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Recurso não encontrado."); // 404 - Not Found
            }
            catch (Exception ex)
            {
                // Logar o erro
                return StatusCode((int)HttpStatusCode.InternalServerError, "Erro interno do servidor.");
            }
        }
    }

}
