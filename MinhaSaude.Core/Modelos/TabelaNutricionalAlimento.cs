using MinhaSaude.Core.Modelos.Abstrato;
using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Core.Modelos;

public class TabelaNutricionalAlimento : TabelaNutricionalBase
{
    // Somente leitura, sempre Alimento
    public TipoTabela TipoTabela => TipoTabela.Alimento;
}
