namespace MinhaSaude.Core.Modelos;

public class Alimento
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public float Porcao { get; set; }
    public bool EstaNaDieta { get; set; }
    public int TabelaNutricionalAlimentoId { get; set; }
    public TabelaNutricionalAlimento TabelaNutricionalAlimento { get; set; }
}
