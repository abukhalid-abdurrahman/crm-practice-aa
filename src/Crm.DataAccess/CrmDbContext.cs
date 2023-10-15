using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccess;

public sealed class CrmDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Client> Clients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        optionsBuilder.UseNpgsql(DatabaseHelper.ConnectionString);
    }
}
