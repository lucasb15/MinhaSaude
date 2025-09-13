namespace MinhaSaude.Core.Modelos.Auxiliares;

public class NutrienteRegistroAux
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required int TipoNutrienteAuxId { get; set; }
    public TipoNutrienteAux? TipoNutrienteAux { get; set; }
}
