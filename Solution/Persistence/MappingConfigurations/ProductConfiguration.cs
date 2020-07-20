﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Persistence.MappingConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(x => x.id).HasDefaultValueSql("newsequentialid()");

            // Seed
            builder.HasData(new List<Product> {
                new Product
                {
                    id = Guid.Parse("6672E891-0D94-4620-B38A-DBC5B02DA9F7"),
                    Code = "TEST",
                    Name = "Test",
                    Description = "Description"
                },
                new Product
                {
                    id = Guid.Parse("CC9D7ECA-6428-4E6D-B40B-2C8D93AB7347"),
                    Code = "PD001",
                    Name = "Iphone X",
                    Description = "Iphone X"
                }
            });
        }
    }
}
