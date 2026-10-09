using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockAPI.Entities;

namespace StockAPI.Data.Configurations
{
    public class ProductsConfig : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Ean).IsRequired().HasMaxLength(13);
            builder.HasIndex(p => p.Ean).IsUnique();
            builder.Property(p => p.Validate).IsRequired();
            builder.Property(p => p.StockQuantity).IsRequired();
        }
    }
}
