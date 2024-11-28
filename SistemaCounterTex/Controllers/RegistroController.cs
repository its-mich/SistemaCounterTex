﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using SistemaCounterTex.Data.interfaz;
using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers
{
    public class RegistroController : Controller
    {
        
            private readonly IRegistro _registro;

            public RegistroController(IRegistro registro)
            {
                _registro = registro;
            }

            [HttpGet(" GetRegistro")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status401Unauthorized)]
            public async Task<IActionResult> GetRegistro()
            {
                var response = await _registro.GetRegistro();
                return Ok(response);
            }

            [HttpPost("PostRegistro")]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> PostRegistro([FromBody] Registro registro)
            {
                try
                {
                    var response = await _registro.PostRegistro(registro);
                    if (response == true)
                        return Ok("perfil ingresado correctamente");
                    else
                        return BadRequest(response);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }


        [HttpDelete("DeleteRegistro/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteRegistro(int id)
        {
            try
            {
                var response = await _registro.DeleteRegistro(id);
                if (response == true)
                    return Ok("Perfil eliminado correctamente");
                else
                    return BadRequest("Error al eliminar el perfil");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}

