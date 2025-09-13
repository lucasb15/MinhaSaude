using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSaude.Core.Modelos;

public class ConsumoAgua
{
    public int Id { get; set; }
    public required DateTime Data { get; set; }
    public required double QuantidadeLitros { get; set; }
    public double? QuantidadeRecomendada { get; set; }
    public string? Observacoes { get; set; } = string.Empty;
}
