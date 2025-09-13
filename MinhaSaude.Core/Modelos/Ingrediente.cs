namespace MinhaSaude.Core.Modelos;

public class Ingrediente
{
    public int Id { get; set; }
    public int ReceiaId { get; set; }
    public int AlimentoId { get; set; }
    public float Quantidade { get; set; }
    public float Porcentagem { get; set; }
    public Alimento Alimento { get; set; }
    public Receita Receita { get; set; }
}