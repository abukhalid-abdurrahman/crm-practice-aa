using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.DataAccess;

public sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> modelBuilder)
    {
        modelBuilder
            .HasKey(p => p.Id)
            .HasName("pk_id");

        modelBuilder
            .Property(p => p.Id)
            .HasColumnType("SERIAL")
            .HasColumnName("id")
            .IsRequired();

        modelBuilder
            .Property(p => p.FirstName)
            .HasColumnName("first_name")
            .HasColumnType("VARCHAR(20)");

        modelBuilder
            .HasMany(o => o.Orders)
            .WithOne(o => o.Client);
    }
}
