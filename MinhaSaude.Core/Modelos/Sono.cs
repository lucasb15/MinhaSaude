using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSaude.Core.Modelos;

public class Sono
{
    public int Id { get; set; }
    public required DateTime DataInicio { get; set; }
    public required DateTime DataFim { get; set; }
    public int? Qualidade { get; set; } // Exemplo: 1 a 5
    public float DuracaoHoras => (float)(DataFim - DataInicio).TotalHours;
    public float? DuracaoRecomendadaHoras { get; set; } // Exemplo: 7 a 9 horas
    public string? Comentarios { get; set; }
}
