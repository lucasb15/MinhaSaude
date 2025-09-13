namespace MinhaSaude.Core.Modelos;

public class Medidas
{
    public int Id { get; set; }
    public DateTime Data { get; set; }

    // Medidas Corporais
    public float Peso { get; set; } // em kg
    public float Altura { get; set; } // em cm
    public float IMC
    {
        get
        {
            if (Altura <= 0 || Peso == 0) return 0;
            return Peso / (Altura * Altura);
        }
    } // Índice de Massa Corporal
    public float? CircunferenciaCintura { get; set; } // em cm
    public float? CircunferenciaQuadril { get; set; } // em cm
    public float? CircunferenciaBraco { get; set; } // em cm
    public float? CircunferenciaPerna { get; set; } // em cm
    public float? CircunferenciaPeito { get; set; } // em cm
    public float? AguaCorporal { get; set; } // em %
    public float? TaxaMetabolicaBasal { get; set; } // em kcal
    public float? MassaMagra { get; set; } // em kg
    public float? MassaGorda { get; set; } // em kg
    public float? GorduraCorporal { get; set; } // em %
    public float? GorduraVisceral { get; set; } // em nível (1-20)
    public float? IdadeCorporal { get; set; } // em anos
    public string? Observacoes { get; set; } = string.Empty;
    public string? FotoProgressoUrl { get; set; } = string.Empty;
}
