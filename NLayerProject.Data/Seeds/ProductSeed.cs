using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;

namespace NLayerProject.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;


        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, Name = "Pilot Kalem", Price = 25.5m, Stock = 100, CategoryId = _ids[0] },
                new Product() { Id = 2, Name = "Tükenmez Kalem", Price = 30, Stock = 200, CategoryId = _ids[0] },
                new Product() { Id = 3, Name = "Kurşun Kalem", Price = 15, Stock = 300, CategoryId = _ids[0] },
                new Product() { Id = 4, Name = "Keçeli Kalem", Price = 20.5m, Stock = 400, CategoryId = _ids[0] },
                new Product() { Id = 5, Name = "Keçeli Kalem", Price = 20.5m, Stock = 400, CategoryId = _ids[0] },
                new Product() { Id = 6, Name = "Büyük Boy Defter", Price = 45.5m, Stock = 300, CategoryId = _ids[1] },
                new Product() { Id = 7, Name = "Orta Boy Defter", Price = 30, Stock = 200, CategoryId = _ids[1] },
                new Product() { Id = 8, Name = "Küçük Boy Defter", Price = 25.5m, Stock = 150, CategoryId = _ids[1] }
                );

        }
    }
}
