namespace MinhaSaude.Core.Modelos;

public class Receita
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required bool EstaNaDieta { get; set; }
    public int TabelaNutricionalReceitaId { get; set; }
    public ICollection<Ingrediente> Ingrediente { get; set; } = new List<Ingrediente>();
    TabelaNutricionalReceita? TabelaNutricionalReceita { get; set; }
}
