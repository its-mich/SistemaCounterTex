using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.Data;
using SistemaCounterTex.Models;
[ApiController]
[Route("api/[controller]")]
public class AdministradorAutoController : ControllerBase
{
    private readonly CounterTexDBContext _context;

    public AdministradorAutoController(CounterTexDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok(await _context. Usuarios.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var item = await _context. Usuarios.FindAsync(id);
        return item != null ? Ok(item) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = usuario.IdUsuario }, usuario);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Usuario usuario)
    {
        if (id != usuario.IdUsuario) return BadRequest();
        _context.Entry(usuario).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null) return NotFound();
        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
