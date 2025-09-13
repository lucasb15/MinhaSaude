using Microsoft.EntityFrameworkCore;
using MinhaSaude.Core.Modelos;
using MinhaSaude.Core.Modelos.Auxiliares;

namespace MinhaSaude.Data.Banco;

public class MinhaSaudeContext : DbContext
{

    // Medidas, Agua, Sono e Exercicios
    public DbSet<Medidas> Medidas { get; set; }
    public DbSet<ConsumoAgua> Agua { get; set; }
    public DbSet<Sono> Sono { get; set; }
    public DbSet<Exercicios> Exercicios { get; set; }

    // Alimentos e Receitas e Tabela Nutricional
    public ConsumoDiario ConsumoDiario { get; set; }
    public DbSet<Alimento> Alimentos { get; set; }
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<TabelaNutricionalAlimento> TabelaNutricionalAlimento { get; set; }
    public DbSet<TabelaNutricionalReceita> TabelaNutricionalReceita { get; set; }
    public DbSet<TabelaNutricionalOutros> TabelaNutricionalOutros { get; set; }

    // Auxiliares
    public DbSet<NutrienteRegistroAux> NutrienteRegistroAux { get; set; }
    public DbSet<UnidadeAux> UnidadeAux { get; set; }
    public DbSet<TipoNutrienteAux> TipoNutrienteAux { get; set; }
    
    private string connectionString = "Data Source=NIKKI\\SQLEXPRESS;Initial Catalog=MinhaSaude;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;

        optionsBuilder
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TabelaNutricionalAlimento>()
            .HasMany(a => a.Outros)
            .WithOne()
            .HasForeignKey(o => o.TabelaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TabelaNutricionalReceita>()
            .HasMany(r => r.Outros)
            .WithOne()
            .HasForeignKey(o => o.TabelaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TabelaNutricionalOutros>()
            .Property(o => o.TipoTabela)
            .HasConversion<int>();
    }
    
}
