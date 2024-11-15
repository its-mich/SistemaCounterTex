﻿using Microsoft.AspNetCore.Mvc;
using SistemaCounterTex.Data.interfaz;
using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers
{
    public class Satelitecontroller : Controller
    {
       

            private readonly ISatelite _satelite;

            public Satelitecontroller(ISatelite satelite)
            {
                _satelite = satelite;
            }

            [HttpGet("GetSatelites")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status401Unauthorized)]
            public async Task<IActionResult> GetProveedor()
            {
                var response = await _satelite.GetSatelites();
                return Ok(response);
            }

            [HttpPost("PostSatelite")]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> PostProveedor([FromBody] Satelite satelite)
            {
                try
                {
                    var response = await _satelite.PostSatelite(satelite);
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

        

    }
}