using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceiroAPI.Data;
using FinanceiroAPI.Models;

namespace FinanceiroAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransacoesController : ControllerBase
{
    private readonly AppDbContext _context;
    public TransacoesController(AppDbContext context) => _context = context;

    // GET com filtros
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Transacao>>> Get(
        DateTime? inicio, DateTime? fim, int? categoriaId, string? tipo)
    {
        var query = _context.Transacoes.Include(t => t.Categoria).AsQueryable();

        if (inicio.HasValue) query = query.Where(t => t.Data >= inicio.Value);
        if (fim.HasValue) query = query.Where(t => t.Data <= fim.Value);
        if (categoriaId.HasValue) query = query.Where(t => t.CategoriaId == categoriaId.Value);
        if (!string.IsNullOrEmpty(tipo)) query = query.Where(t => t.Categoria!.Tipo == tipo);

        return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Transacao>> GetById(int id)
    {
        var transacao = await _context.Transacoes.Include(t => t.Categoria)
            .FirstOrDefaultAsync(t => t.Id == id);
        return transacao == null ? NotFound() : transacao;
    }

    [HttpPost]
    public async Task<ActionResult<Transacao>> Post(Transacao transacao)
    {
        if (transacao.Valor <= 0) return BadRequest("Valor deve ser maior que zero.");
        if (transacao.Data > DateTime.Now) return BadRequest("Data não pode ser futura.");

        var categoria = await _context.Categorias.FindAsync(transacao.CategoriaId);
        if (categoria == null || !categoria.Ativo)
            return BadRequest("Categoria inválida ou inativa.");

        _context.Transacoes.Add(transacao);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = transacao.Id }, transacao);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Transacao transacao)
    {
        if (id != transacao.Id) return BadRequest();
        _context.Entry(transacao).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var transacao = await _context.Transacoes.FindAsync(id);
        if (transacao == null) return NotFound();
        _context.Transacoes.Remove(transacao);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
