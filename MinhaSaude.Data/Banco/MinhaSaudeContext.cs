using Microsoft.EntityFrameworkCore;

namespace MinhaSaude.Data.Banco;

public class MinhaSaudeContext : DbContext
{

    private string connectionString = "Data Source=NIKKI\\SQLEXPRESS;Initial Catalog=MinhaSaude;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;

        optionsBuilder
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }
}
