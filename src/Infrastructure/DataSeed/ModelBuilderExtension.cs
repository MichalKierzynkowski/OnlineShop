using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataSeed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var stock = new Faker<Product>()
              .RuleFor(m => m.Id, f => Guid.NewGuid())
              .RuleFor(m => m.Name, f => f.Commerce.ProductName())
              .RuleFor(m => m.CategoryId, f => f.Random.Guid())
              .RuleFor(m => m.ProductDetailId, f => f.Random.Guid());


            
            modelBuilder
                .Entity<Product>()
                .HasData(stock.GenerateBetween(10, 100));
        }
    }
}
