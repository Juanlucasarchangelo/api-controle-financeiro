using Microsoft.EntityFrameworkCore;
using FinanceiroAPI.Models;

namespace FinanceiroAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }
}
