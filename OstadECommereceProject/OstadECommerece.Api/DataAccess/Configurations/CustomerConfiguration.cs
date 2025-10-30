using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OstadECommerece.Api.Models;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.FullName)
               .IsRequired()
               .HasMaxLength(120);

        builder.Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(150);

        builder.HasIndex(c => c.Email)
               .IsUnique();

        builder.HasMany(c => c.Orders)
               .WithOne(o => o.Customer)
               .HasForeignKey(o => o.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
