using Bogus;
using ECommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            Faker faker = new("tr"); // Bu yapı ve kütüphane sayesinde tr dilinde örnek değişkenler oluşturabiliyoruz. (LIBRARY -> BOGUS)

            Brand brandSample1 = new()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Brand brandSample2 = new()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Brand brandSample3 = new()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                isDeleted = true
            };

            builder.HasData(brandSample1, brandSample2, brandSample3);
        }
    }
}
