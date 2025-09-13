using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Core.Modelos;

public class Exercicios
{
    public int Id { get; set; }
    public required DateTime Data { get; set; }
    public required string TipoExercicio { get; set; }
    public required int DuracaoMinutos { get; set; }
    public double? CaloriasQueimadas { get; set; }
    public string? Observacoes { get; set; } = string.Empty;
}
