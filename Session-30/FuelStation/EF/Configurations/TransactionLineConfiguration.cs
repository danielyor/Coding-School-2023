using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            // Table Name
            builder.ToTable("TransactionLines");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.TransactionId).IsRequired();
            builder.Property(t => t.ItemId).IsRequired();
            builder.Property(t => t.Quantity).IsRequired();
            builder.Property(t => t.ItemPrice).IsRequired();
            builder.Property(t => t.NetValue).IsRequired();
            builder.Property(t => t.DiscountPercent);
            builder.Property(t => t.DiscountValue);
            builder.Property(t => t.TotalValue).IsRequired();

            // Relations
            builder.HasOne(t => t.Transaction)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Item)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.ItemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
