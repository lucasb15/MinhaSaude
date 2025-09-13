using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Core.Modelos;

public class TabelaNutricionalOutros
{
    public int Id { get; set; }
    public int TabelaId { get; set; }
    public TipoTabela TipoTabela { get; private set; } // somente leitura
    public int NutrienteRegistroAuxId { get; set; }
    public NutrienteRegistroAux Nutriente { get; set; }
    public float Quantidade { get; set; } = 0;

    public TabelaNutricionalOutros(TipoTabela tipoTabela)
    {
        TipoTabela = tipoTabela;
    }
}