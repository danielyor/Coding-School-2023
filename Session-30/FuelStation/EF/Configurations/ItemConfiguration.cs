using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            // Table Name
            builder.ToTable("Items");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Code).HasMaxLength(20).IsRequired();
            builder.HasIndex(t => t.Code).IsUnique();
            builder.Property(t => t.Description).HasMaxLength(150).IsRequired();
            builder.Property(t => t.Type).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Cost).IsRequired();

            // Relations

        }
    }
}
