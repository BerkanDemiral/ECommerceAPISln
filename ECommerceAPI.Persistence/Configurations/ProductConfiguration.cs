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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr"); // Bu yapı ve kütüphane sayesinde tr dilinde örnek değişkenler oluşturabiliyoruz. (LIBRARY -> BOGUS)

            Product productSample1 = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Product productSample2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 3,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Product productSample3 = new()
            {
                Id = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 2,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
        }
    }
}
