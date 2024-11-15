using Microsoft.AspNetCore.Mvc;
using SistemaCounterTex.Data.interfaz;
using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers
{
    public class Provedorcontroller : Controller
    {
       
            private readonly IProvedor _provedor;

            public Provedorcontroller(IProvedor provedor)
            {
                _provedor = provedor;
            }

            [HttpGet("GetProveedor")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status401Unauthorized)]
            public async Task<IActionResult> GetProveedor()
            {
                var response = await _provedor.GetProveedor();
                return Ok(response);
            }

            [HttpPost("PostProveedor")]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> PostProveedor([FromBody] Proveedor provedor)
            {
                try
                {
                    var response = await _provedor.PostProveedor(provedor);
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
