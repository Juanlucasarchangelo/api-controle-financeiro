using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceiroAPI.Data;

namespace FinanceiroAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RelatoriosController : ControllerBase
{
    private readonly AppDbContext _context;
    public RelatoriosController(AppDbContext context) => _context = context;

    [HttpGet("resumo")]
    public async Task<IActionResult> Resumo(DateTime inicio, DateTime fim)
    {
        var transacoes = await _context.Transacoes
            .Include(t => t.Categoria)
            .Where(t => t.Data >= inicio && t.Data <= fim)
            .ToListAsync();

        var receitas = transacoes.Where(t => t.Categoria!.Tipo == "Receita").Sum(t => t.Valor);
        var despesas = transacoes.Where(t => t.Categoria!.Tipo == "Despesa").Sum(t => t.Valor);

        return Ok(new { Saldo = receitas - despesas, Receitas = receitas, Despesas = despesas });
    }

    [HttpGet("por-categoria")]
    public async Task<IActionResult> PorCategoria(DateTime inicio, DateTime fim)
    {
        var resultado = await _context.Transacoes
            .Include(t => t.Categoria)
            .Where(t => t.Data >= inicio && t.Data <= fim)
            .GroupBy(t => t.Categoria!.Nome)
            .Select(g => new { Categoria = g.Key, Total = g.Sum(t => t.Valor) })
            .ToListAsync();

        return Ok(resultado);
    }
}