using MinhaSaude.Core.Modelos.Abstrato;
using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Core.Modelos;

public class TabelaNutricionalReceita : TabelaNutricionalBase
{
    // Somente leitura, sempre Receita
    public TipoTabela TipoTabela => TipoTabela.Receita;
}
