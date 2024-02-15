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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();

            Faker faker = new("tr"); // Bu yapı ve kütüphane sayesinde tr dilinde örnek değişkenler oluşturabiliyoruz. (LIBRARY -> BOGUS)

            Detail detailSample1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1), // sentence -> kelime sayısı
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Detail detailSample2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(1), // sentence -> kelime sayısı
                Description = faker.Lorem.Sentence(5),
                CategoryId = 2,
                CreatedDate = DateTime.Now,
                isDeleted = false
            };
            Detail detailSample3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1), // sentence -> kelime sayısı
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreatedDate = DateTime.Now,
                isDeleted = false
            };

            builder.HasData(detailSample1, detailSample2, detailSample3);

        }
    }
}
