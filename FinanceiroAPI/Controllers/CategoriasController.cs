using Microsoft.AspNetCore.Mvc;
using FinanceiroAPI.Data;
using FinanceiroAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceiroAPI.Controllers;

[ApiController]
[Route("api/")]
public class CategoriasController : ControllerBase
{
    private readonly AppDbContext _context;
    public CategoriasController(AppDbContext context) => _context = context;

    [HttpGet("listar-categorias")]
    public async Task<ActionResult<IEnumerable<Categoria>>> Get() =>
        await _context.Categorias.ToListAsync();

    [HttpPost("cadastrar-categorias")]
    public async Task<ActionResult<Categoria>> Post(Categoria categoria)
    {
        _context.Categorias.Add(categoria);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = categoria.Id }, categoria);
    }
}
