using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Core.Modelos.Abstrato;

public abstract class TabelaNutricionalBase
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required float Calorias { get; set; }
    public float? Proteinas { get; set; } = 0;
    public float? Carboidratos { get; set; } = 0;
    public float? GordurasTotais { get; set; } = 0;
    public float? GordurasSaturadas { get; set; } = 0;
    public float? GordurasTrans { get; set; } = 0;
    public float? FibraAlimentar { get; set; } = 0;
    public float? Sodio { get; set; } = 0;

    public ICollection<TabelaNutricionalOutros> Outros { get; set; } = new List<TabelaNutricionalOutros>();

    // Método auxiliar para adicionar nutrientes extras
    protected void AdicionarOutro(int nutrienteRegistroAuxId, float quantidade, TipoTabela tipoTabela)
    {
        Outros.Add(new TabelaNutricionalOutros(tipoTabela)
        {
            NutrienteRegistroAuxId = nutrienteRegistroAuxId,
            Quantidade = quantidade
        });
    }
}
