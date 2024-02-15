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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            Faker faker = new("tr"); // Bu yapı ve kütüphane sayesinde tr dilinde örnek değişkenler oluşturabiliyoruz. (LIBRARY -> BOGUS)

            Category categorySample1 = new()
            {
                Id= 1,
                Name="Bilgisayar",
                Priority= 1,
                ParentId= 0,
                isDeleted= false,
                CreatedDate= DateTime.Now
            };
            Category categorySample2 = new()
            {
                Id = 2,
                Name = "Mobilya",
                Priority = 1,
                ParentId = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category parent1Sample = new()
            {
                Id = 3,
                Name = "Oyun Bilgisayarı",
                Priority = 1,
                ParentId = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category parent2Sample = new()
            {
                Id = 3,
                Name = "Koltuk Takımı",
                Priority = 1,
                ParentId = 2,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };

            builder.HasData(categorySample1, categorySample2, parent1Sample, parent2Sample);
        }
    }
}
