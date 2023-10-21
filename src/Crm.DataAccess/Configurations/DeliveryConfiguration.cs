using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.DataAccess;

public sealed class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
        builder
            .HasOne(c => c.Order)
            .WithOne(c => c.Delivery)
            .HasForeignKey<Order>(d => d.DeliveryId);
    }
}

