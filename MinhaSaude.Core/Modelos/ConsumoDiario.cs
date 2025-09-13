using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSaude.Core.Modelos;

public class ConsumoDiario
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public int? AlimentoId { get; set; }
    public int? ReceitaId { get; set; }
    public float Quantidade { get; set; }

}
