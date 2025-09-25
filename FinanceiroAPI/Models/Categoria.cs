namespace FinanceiroAPI.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Tipo { get; set; } = null!;
    public bool Ativo { get; set; } = true;
}
