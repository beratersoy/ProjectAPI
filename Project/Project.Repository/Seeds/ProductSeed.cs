using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "iphone 13", CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 2, Name = "macbook", CreatedDate = DateTime.Now },
                 new Product { Id = 3, CategoryId = 3, Name = "canon eos2000d", CreatedDate = DateTime.Now });
        }
    }
}
